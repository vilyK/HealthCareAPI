namespace HealthCare.API.Authentication.Models
{
    using System.Security.Claims;

    public interface IAuthContainerMode
    {
        string SecretKey { get; set; }

        string SecurityAlgorithm { get; set; }

        int ExpireMinutes { get; set; }

        Claim[] Claims { get; set; }
    }
}