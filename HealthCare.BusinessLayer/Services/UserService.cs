namespace HealthCare.BusinessLayer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Threading.Tasks;
    using AutoMapper;
  
    using Contracts.Interfaces;
    using Contracts.Models.UserAccount.Data;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    using DataLayer;
    using DataLayer.Entities.MedicalCenter;
    using DataLayer.Entities.MedicalMan;
    using DataLayer.Entities.Patient;
    using DataLayer.Entities.Pharmacy;
    using DataLayer.Entities.PharmacyCompany;
    using DataLayer.Entities.User;
    using Extensions;
    using Interfaces;
    using Utilities.Enums;
    using Utilities.Exceptions;
    using Utilities.Exceptions.ImagesExceptions;

    public class UserService : IUserService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ISessionResolver _sessionResolver;
        private readonly IContactsService _contactsService;
        private readonly IImageService _imageService;

        private const int SaltByteSize = 64;
        private const int HashByteSize = 256;
        private const int HashingIterationsCount = 10000;

        public UserService(HealthCareDbContext dbContext,
            IMapper mapper,
            ISessionResolver sessionResolver,
            IContactsService contactsService,
            IImageService imageService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _sessionResolver = sessionResolver;
            _contactsService = contactsService;
            _imageService = imageService;
        }

        public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
        {
            var userExists = RetrieveUserByUsername(request.GeneralData.Username);
            ValidationUtils.ValidateAndThrow<ExistedUserException>(() => userExists != null);

            var (hashedPassword, secret) = GenerateSaltedHash(request.GeneralData.Password);

            var user = new User
            {
                Username = request.GeneralData.Username,
                PasswordHash = hashedPassword,
                Secret = secret,
                RoleType = (RoleType)Enum.ToObject(typeof(RoleType), request.UserRole)
            };

            var userContact = new UserContact
            {
                User = user
            };

            _dbContext.AddRange(user, userContact);

            PersistUserContacts(request.Contacts, userContact.Id, DatabaseOperation.Insert);
            AddInformation(user.Id, request.Name, user.RoleType);
            
            await _dbContext.SaveChangesAsync();

            return new RegisterUserResponse
            {
                Username = request.GeneralData.Username
            };
        }

        private void AddInformation(int userId, string requestName, RoleType userRoleType)
        {
            switch (userRoleType)
            {
                case RoleType.Patient:
                    {
                        _dbContext.CreateInfoObject<PatientInfo>(requestName, userId);
                        break;
                    }
                case RoleType.Doctor:
                    {
                        _dbContext.CreateInfoObject<MedicalManInfo>(requestName, userId);
                        break;
                    }
                case RoleType.MedicalCenter:
                    {
                        _dbContext.CreateInfoObject<MedicalCenterInfo>(requestName, userId);
                        break;
                    }
                case RoleType.Pharmacy:
                    {
                        _dbContext.CreateInfoObject<PharmacyInfo>(requestName, userId);
                        break;
                    }
                case RoleType.PharmacyCompany:
                    {
                        _dbContext.CreateInfoObject<PharmacyCompanyInfo>(requestName, userId);
                        break;
                    }
                default:
                    throw new IncorrectUserDataException();
            }
        }

        public async Task<LoginUserResponse> LoginUser(LoginUserRequest request)
        {
            var user = RetrieveUserByUsername(request.Username);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => user == null);

            var isPasswordMatch = VerifyPassword(request.Password, user.PasswordHash, user.Secret);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => !isPasswordMatch);

            return new LoginUserResponse
            {
                Username = request.Username
            };
        }

        public async Task<AddContactResponse> AddContact(AddContactRequest request)
        {
            var userContactId = _dbContext.UserContacts.SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId)?.Id;

            PersistUserContacts(request.Contacts, userContactId.GetValueOrDefault(), DatabaseOperation.Insert);

            await _dbContext.SaveChangesAsync();

            return new AddContactResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<EditUserGeneraDataResponse> EditGeneralData(EditUserGeneraDataRequest request)
        {
            var user = RetrieveUser(_sessionResolver.SessionInfo.Username, _sessionResolver.SessionInfo.UserId);

            if (!request.GeneralData.IsNullOrEmpty())
            {
                EditUsernameAndPass(request.GeneralData, user);
            }

            var userContactId = _dbContext.UserContacts.SingleOrDefault(x => x.UserId == _sessionResolver.SessionInfo.UserId)?.Id;
            ValidationUtils.ValidateAndThrow<DataMismatchException>(() => userContactId == 0);

            PersistUserContacts(request.Contacts, userContactId.GetValueOrDefault(), DatabaseOperation.Update);

            await _dbContext.SaveChangesAsync();

            return new EditUserGeneraDataResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public async Task<UploadImagesResponse> UploadImages(UploadImagesRequest request)
        {
            UploadProfilePhotos(request.Images);

            await _dbContext.SaveChangesAsync();

            return new UploadImagesResponse
            {
                Token = _sessionResolver.SessionInfo.NewToken
            };
        }

        public Task<RetrieveDoctorsResponse> RetrieveDoctors(RetrieveDoctorsRequest request)
        {
            var users = _dbContext.Users.Where(u => u.RoleType == RoleType.Doctor).Where(u => u.MedicalManInfo.IsNzok == request.WorkingWithNzok)
                .Where(u => u.MedicalManInfo.IsAdditionalHealthInsurance == request.IsAdditionalHealthInsurance)
                .Where(u => u.MedicalManInfo.ExperienceInYears > request.Experience.ExperienceInYearsLowLimit
                            && u.MedicalManInfo.ExperienceInYears < request.Experience.ExperienceInYearsHighLimit)
                .Where(s => request.DoctorCategories.CategoryIds
                    .Any(_dbContext.MedicalManSpecialties
                        .SelectMany(u => u.MedManInfo.Specialties
                            .Select(sp => sp.SpecialtyId))
                        .ToList()
                        .Contains))
                .Where(c => request.Cities.CityIds
                    .Any(_dbContext.Users
                        .SelectMany(u => u.UserContact.Addresses
                            .Select(city => city.CityId))
                        .ToList()
                        .Contains))
                .ToList();

            var map = _mapper.Map<RetrieveDoctorsResponse>(users);

            throw new NotImplementedException();
        }

        public Task<RetrieveMedicalCentersResponse> RetrieveMedicalCenters(RetrieveMedicalCentersRequest request)
        {
            throw new NotImplementedException();
        }

        public void UploadProfilePhotos(List<ImageData> imagesInRequest)
        {
            // check for more than one main photos -> should be imported in FluentValidation
            ValidationUtils.ValidateAndThrow<IncorrectMainPhotosCountException>(() => imagesInRequest.Count(x => x.IsMain) > 1);

            // validation if photos in request belong to the logged customer
            var userPhotos = _dbContext.Photos
                .Where(x => x.UserId == _sessionResolver.SessionInfo.UserId)
                .Select(x => x.Id)
                .ToList();

            var existedPhotosInRequest = imagesInRequest
                .Where(x => x.Id != 0)
                .Select(x => x.Id)
                .ToList();

            ValidationUtils.ValidateAndThrow<DataMismatchException>(
                () => existedPhotosInRequest.Count > 0 && !existedPhotosInRequest.All(userPhotos.Contains));

            _imageService.UploadImages(imagesInRequest);
        }

        private User RetrieveUser(string username, int userId)
        {
            var user = _dbContext.Users.SingleOrDefault(x => x.Id == userId && x.Username == username);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => user == null);

            return user;
        }

        private User RetrieveUserByUsername(string username)
        {
            return _dbContext.Users.SingleOrDefault(x => x.Username == username);
        }

        private void EditUsernameAndPass(GeneralUserData data, User user)
        {
            if (data.Username != null)
            {
                user.Username = data.Username;
            }

            if (data.Password != null)
            {
                var (hashedPassword, salt) = GenerateSaltedHash(data.Password);
                user.PasswordHash = hashedPassword;
                user.Secret = salt;
            }

            user.UpdateDate = DateTime.Now;
        }

        private void PersistUserContacts(ContactUserData contacts, int userContactId, DatabaseOperation operation)
        {
            _contactsService.PersistEntities<AddressData, Address>(contacts.Addresses.EmptyIfNull(), userContactId, operation);
            _contactsService.PersistEntities<EmailData, Email>(contacts.Emails.EmptyIfNull(), userContactId, operation);
            _contactsService.PersistEntities<PhoneData, Phone>(contacts.Phones.EmptyIfNull(), userContactId, operation);
        }

        private (string, string) GenerateSaltedHash(string password)
        {
            using (var provider = new RNGCryptoServiceProvider())
            {
                var saltBytes = new byte[SaltByteSize];
                provider.GetNonZeroBytes(saltBytes);
                var salt = Convert.ToBase64String(saltBytes);

                using (var hashGenerator = new Rfc2898DeriveBytes(password, saltBytes, HashingIterationsCount))
                {
                    var hashPassword = Convert.ToBase64String(hashGenerator.GetBytes(HashByteSize));

                    return (hashPassword, salt);
                }
            }
        }

        private bool VerifyPassword(string password, string storedHash, string salt)
        {
            var saltBytes = Convert.FromBase64String(salt);

            using (var hashGenerator = new Rfc2898DeriveBytes(password, saltBytes, HashingIterationsCount))
            {
                var generatedHash = Convert.ToBase64String(hashGenerator.GetBytes(HashByteSize));

                return generatedHash == storedHash;
            }
        }
    }
}
