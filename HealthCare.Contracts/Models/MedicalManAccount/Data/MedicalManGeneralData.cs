namespace HealthCare.Contracts.Models.MedicalManAccount.Data
{
    using HealthCare.Interfaces;

    public class MedicalManGeneralData : IName
    {
        public string Name { get; set; }

        public string Biography { get; set; }

        public bool IsNzok { get; set; }

        public bool IsAdditionalHealthInsurance { get; set; }

        public int ExperienceInYears { get; set; }
    }
}
