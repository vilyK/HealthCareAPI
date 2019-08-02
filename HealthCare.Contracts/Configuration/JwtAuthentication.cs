namespace HealthCare.Contracts.Configuration
{
    public class JwtAuthentication
    {
        public string SecurityKey { get; set; }

        public string ValidIssuer { get; set; }

        public string ValidAudience { get; set; }
    }
}
