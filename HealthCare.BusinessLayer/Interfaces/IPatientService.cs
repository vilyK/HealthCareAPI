namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.Appointment.Responses;
    using Contracts.Models.Common;
    using Contracts.Models.OutpatientCard.Responses;
    using Contracts.Models.PatientAccount.Requests;
    using Contracts.Models.PatientAccount.Responses;

    public interface IPatientService
    {
        Task<TokenData> PersistMedicalProfile(PersistMedicalProfileRequest request);

        Task<GetPatientByEgnResponse> GetPatientByEng(int egn);
        
        Task<GetPatientAppointmentsResponse> GetAppointments(int patientInfoId);

        GetOutPatientCardsResponse GetOutPatientCards(int patientInfoId);
    }
}