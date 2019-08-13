namespace HealthCare.Contracts.Configuration
{
    using HealthCare.Interfaces.Configuration;

    public class SeedSettings : ISeedSettings
    {
        public string SeedDirectory { get; set; }
    }
}
