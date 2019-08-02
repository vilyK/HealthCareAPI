namespace HealthCare.API.Authentication.Models
{
    using System.Security.Claims;
    using Microsoft.IdentityModel.Tokens;

    public class JWTContainerModel
    {
        public string SecretKey { get; set; } = "XXzYkyJmfyGaBhNJ0soDxRhcu9d65we5jP9UqhbeXOQ=";

        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;

        public int ExpireMinutes { get; set; } = 60;

        public Claim[] Claims { get; set; }
    }
}
