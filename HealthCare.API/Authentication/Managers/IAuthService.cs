namespace HealthCare.API.Authentication.Managers
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using Models;

    public interface IAuthService
    {
        string SecretKey { get; set; }

        bool IsTokenValid(string token);

        string GenerateToken(IAuthContainerMode model);

        IEnumerable<Claim> GetTokenClaims(string token);
    }
}