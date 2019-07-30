namespace HealthCare.BusinessLayer
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Security.Cryptography;
    using AutoMapper;

    using Contracts.Models.Requests;
    using Contracts.Models.Responses;
    using DataLayer;
    using DataLayer.Entities.User;
    using Interfaces;
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
            var userExists = UserExists(request.Username);
            if (userExists)
            {
                throw new UserIncorrectDataException("Username has been already exist.", "UserExists");
            }
            
            var (hashedPassword, salt) = GenerateSaltedHash(request.Password);

            var user = _mapper.Map<User>(request);
            user.PasswordHash = hashedPassword;
            user.PasswordSalt = salt;

            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return new RegisterUserResponse
            {
                Username = request.Username
            };
        }

        public async Task<LoginUserResponse> LoginUser(LoginUserRequest request)
        {
            var userExists = UserExists(request.Username);
            if (userExists)
            {
                throw new UserIncorrectDataException("Username has been already exist.", "UserExists");
            }

            var user = _dbContext.Users.FirstOrDefault(u => u.Username == request.Username);

            var isPasswordMatch = VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt);

            if (!isPasswordMatch)
            {
                throw new UserIncorrectDataException("Username or password is wrong.", "UserNotFound");
            }
            
            return new LoginUserResponse
            {
                Username = request.Username
            };
        }

        private bool UserExists(string username)
        {
            return _dbContext.Users.Any(u => u.Username == username);
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
