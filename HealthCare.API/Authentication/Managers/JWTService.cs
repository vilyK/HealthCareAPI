namespace HealthCare.API.Authentication.Managers
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Runtime.InteropServices;
    using System.Security.Claims;
    using Microsoft.IdentityModel.Tokens;
    using Models;

    public class JWTService : IAuthService
    {
        public string SecretKey { get; set; }

        public JWTService(string secretKey)
        {
            SecretKey = secretKey;
        }

        public bool IsTokenValid(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("Given token is null or empty!");

            var tokenValidationParameters = GetTokenValidationParameters();

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            
            try
            {
                jwtSecurityTokenHandler
                    .ValidateToken(token, tokenValidationParameters, out var validatedToken);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private TokenValidationParameters GetTokenValidationParameters()
        {
            return new TokenValidationParameters
            {
                ValidateActor = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                //ValidIssuer = jwtAuthentication.ValidIssuer,
                //ValidAudience = jwtAuthentication.ValidAudience,
                //IssuerSigningKey = jwtAuthentication.SymmetricSecurityKey,
                NameClaimType = ClaimTypes.NameIdentifier
            };
        }

        public string GenerateToken(IAuthContainerMode model)
        {
            if (model?.Claims == null || model.Claims.Length == 0)
                 throw new ArgumentException("Invalid token arguments");

            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(model.Claims),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt32(model.ExpireMinutes)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Convert.FromBase64String(model.SecretKey)),
                    model.SecurityAlgorithm)
            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

            return jwtSecurityTokenHandler.WriteToken(securityToken);
        }

        public IEnumerable<Claim> GetTokenClaims(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("Given token is null or empty!");

            var tokenValidationParameters = GetTokenValidationParameters();

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

            var tokenValid = jwtSecurityTokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);

            return tokenValid.Claims;

        }
    }
}
