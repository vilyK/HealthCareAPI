namespace HealthCare.Contracts.Models.PatientAccount.Data
{
    using Utilities.Enums;

    public class IllnessData
    {
        public int Id { get; set; }

        public int IllnessTypeId { get; set; }

        public IllnessPeriod IllnessPeriod { get; set; }
    }
}
