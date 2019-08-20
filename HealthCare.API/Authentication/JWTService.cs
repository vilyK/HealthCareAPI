namespace HealthCare.API.Authentication
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;

    using BusinessLayer.Extensions;
    using Contracts.Configuration;
    using Utilities.Exceptions;

    public class JWTService : IAuthService
    {
        private string SecurityKey { get; }

        private readonly IOptionsSnapshot<JwtAuthentication> _config;

        public JWTService(IOptionsSnapshot<JwtAuthentication> config)
        {
            _config = config;

            SecurityKey = _config.Value.SecurityKey;
        }

        public (string, int) RetrieveTokenData(string token)
        {
            token = token.Replace("Bearer ", "");
            ValidationUtils.ValidateAndThrow<InvalidTokenException>(() => string.IsNullOrEmpty(token));

            var tokenClaims = ExtractClaims(token);

            var userId = tokenClaims.Find(x => x.Type == "userId").Value;
            var userName = tokenClaims.Find(x => x.Type == ClaimTypes.Name).Value;
            int.TryParse(userId, out var id);

            return (userName, id);
        }

        public string GenerateToken(string username, int userId)
        {
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim("userId", userId.ToString()),
                }),
                Expires = DateTime.Now.AddMonths(Convert.ToInt32(_config.Value.ExpirationInMinutes)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Convert.FromBase64String(SecurityKey)),
                    SecurityAlgorithms.HmacSha256)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(securityToken);
        }

        private TokenValidationParameters GetTokenValidationParameters()
        {
            return new TokenValidationParameters
            {
                RequireExpirationTime = true,
                
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(SecurityKey)),
            };
        }

        private List<Claim> ExtractClaims(string token)
        {
            try
            {
                var validationParameters = GetTokenValidationParameters();

                var t = GenerateToken("newName", 8);

                var tokenHandler = new JwtSecurityTokenHandler();

                var tokenValid = tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);

                return tokenValid.Claims.ToList();
            }
            catch (SecurityTokenExpiredException)
            {
                throw new ExpiredTokenException();
            }
            catch (Exception)
            {
                throw new InvalidTokenException();
            }
        }
    }
}
