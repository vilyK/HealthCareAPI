namespace HealthCare.Contracts.Configuration
{
    public class EmailConfiguration
    {
        public string SmtpHost { get; set; }

        public int SmtpPort { get; set; }

        public bool EnableSsl { get; set; }

        public string SmtpUsername { get; set; }

        public string SmtpPassword { get; set; }
    }
}
