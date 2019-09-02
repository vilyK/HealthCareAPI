namespace HealthCare.Contracts.Models.MedicalManAccount.Data
{

    public class MedicalManGeneralData
    {
        public string Name { get; set; }

        public string Biography { get; set; }

        public bool IsNzok { get; set; }

        public bool IsAdditionalHealthInsurance { get; set; }

        public int ExperienceInYears { get; set; }
    }
}
