namespace HealthCare.Contracts.Configuration
{
    using Interfaces.Configuration;

    public class SeedSettings : ISeedSettings
    {
        public string SeedDirectory { get; set; }
    }
}
