namespace HealthCare.BusinessLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using AutoMapper;

    using Contracts.CommonModels;
    using Contracts.Models.Requests;
    using Contracts.Models.Responses;
    using Contracts.Models.UserAccount.Data;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    using DataLayer;
    using DataLayer.Entities.User;
    using Extensions;
    using Interfaces;
    using Models.DatabaseModels.Enums;
    using Utilities.Enums;
    using Utilities.Exceptions;

    public class UserService : IUserService
    {
        private readonly HealthCareDbContext _dbContext;
        private readonly IMapper _mapper;

        private const int SaltByteSize = 64;
        private const int HashByteSize = 256;
        private const int HashingIterationsCount = 10000;

        public UserService(HealthCareDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
        {
            var userExists = RetrieveUserByUsername(request.GeneralData.Username);
            ValidationUtils.ValidateAndThrow<MissingUserException>(() => userExists != null);

            var (hashedPassword, salt) = GenerateSaltedHash(request.GeneralData.Password);

            var user = new User
            {
                Username = request.GeneralData.Username,
                PasswordHash = hashedPassword,
                PasswordSalt = salt,
                RoleType = (RoleType)Enum.ToObject(typeof(RoleType), request.UserRole)
            };

            _dbContext.Users.Add(user);

            AddUserContact(user, request);

            await _dbContext.SaveChangesAsync();

            return new RegisterUserResponse
            {
                Username = request.GeneralData.Username
            };
        }

        public async Task<LoginUserResponse> LoginUser(LoginUserRequest request)
        {
            var user = RetrieveUserByUsername(request.Username);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => user == null);

            var isPasswordMatch = VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => !isPasswordMatch);

            return new LoginUserResponse
            {
                Username = request.Username
            };
        }

        public async Task<EditUserGeneraDataResponse> EditGeneralData(EditUserGeneraDataRequest request)
        {
            var user = RetrieveUserById(request.UserId); // should be taken from the token
            ValidationUtils.ValidateAndThrow<IncorrectUserDataException>(() => user == null);

            if (!request.GeneralData.IsNullOrEmpty())
            {
                EditGeneralData(request.GeneralData, user);
            }

            if (!request.Contacts.IsNullOrEmpty())
            {
                var userContactId = _dbContext.UserContacts.SingleOrDefault(x => x.UserId == user.Id).Id;
                var contacts = request.Contacts;

                EditAddresses(contacts.Addresses, userContactId);
                EditEmails(contacts.Emails, userContactId);
                EditPhones(contacts.Phones, userContactId);
            }

            await _dbContext.SaveChangesAsync();

            return new EditUserGeneraDataResponse
            {
                UserId = request.UserId
            };
        }

        private User RetrieveUserByUsername(string username)
        {
            return _dbContext.Users.SingleOrDefault(x => x.Username == username);
        }

        private User RetrieveUserById(int id)
        {
            return _dbContext.Users.SingleOrDefault(x => x.Id == id);
        }

        private void EditGeneralData(GeneralUserData data, User user)
        {
            if (data.Username != null)
            {
                user.Username = data.Username;
            }

            if (data.Password != null)
            {
                var (hashedPassword, salt) = GenerateSaltedHash(data.Password);
                user.PasswordHash = hashedPassword;
                user.PasswordSalt = salt;
            }
        }

        private void EditAddresses(IEnumerable<AddressData> addresses, int userContactId)
        {
            foreach (var add in addresses)
            {
                var addressRecord = _dbContext.Addresses.SingleOrDefault(x => x.Id == add.Id && x.UserContactId == userContactId);
                ValidationUtils.ValidateAndThrow<DataMismatchException>(() => addressRecord == null);

                addressRecord.CityId = add.CityId;
                addressRecord.IsCurrent = add.IsCurrent;
                addressRecord.StreetAddress = add.StreetAddress;
            }
        }

        private void EditEmails(IEnumerable<EmailData> emails, int userContactId)
        {
            foreach (var email in emails)
            {
                var emailRecord = _dbContext.Emails.SingleOrDefault(x => x.Id == email.Id && x.UserContactId == userContactId);
                ValidationUtils.ValidateAndThrow<DataMismatchException>(() => emailRecord == null);

                emailRecord.EmailAddress = email.EmailAddress;
            }
        }

        private void EditPhones(IEnumerable<PhoneData> phones, int userContactId)
        {
            foreach (var phone in phones)
            {
                var phoneRecord = _dbContext.Phones.SingleOrDefault(x => x.Id == phone.Id && x.UserContactId == userContactId);
                ValidationUtils.ValidateAndThrow<DataMismatchException>(() => phoneRecord == null);

                phoneRecord.Number = phone.PhoneNumber;
                phoneRecord.Type = (PhoneType)phone.PhoneType;
            }
        }

        private void AddUserContact(User user, RegisterUserRequest request)
        {
            var userContact = new UserContact
            {
                User = user
            };

            var contacts = request.Contacts;

            var address = contacts.Addresses[0];
            var userAddress = new Address
            {
                UserContact = userContact,
                CityId = address.CityId,
                IsCurrent = true,
                StreetAddress = address.StreetAddress
            };

            var phone = contacts.Phones[0];
            var userPhone = new Phone
            {
                UserContact = userContact,
                Number = phone.PhoneNumber,
                Type = (PhoneType)phone.PhoneType
            };

            var email = contacts.Emails[0];
            var userEmail = new Email
            {
                UserContact = userContact,
                EmailAddress = email.EmailAddress
            };

            _dbContext.AddRange(userContact, userAddress, userPhone, userEmail);
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
