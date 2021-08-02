namespace HealthCare.Contracts.Models.PatientAccount.Responses
{
    using Common;

    public class GetPatientByEgnResponse : TokenData
    {
        public PatientInfoData Patient { get; set; }
    }
}
