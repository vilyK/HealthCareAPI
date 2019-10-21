namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;

    using Contracts.Models.MedicalCenterAccount.Requests;
    using Contracts.Models.MedicalCenterAccount.Responses;

    public interface IMedicalCenterService
    {
        Task<PersistMedicalCenterDataResponse> PersistMedicalCenterData(PersistMedicalCenterDataRequest request);
    }
}
