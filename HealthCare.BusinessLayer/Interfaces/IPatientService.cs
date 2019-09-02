namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.PatientAccount.Requests;
    using Contracts.Models.PatientAccount.Responses;

    public interface IPatientService
    {
        Task<PersistMedicalProfileResponse> PersistMedicalProfile(PersistMedicalProfileRequest request);
    }
}