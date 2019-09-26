namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;

    using Contracts.Models.MedicalManAccount.Requests;
    using Contracts.Models.MedicalManAccount.Responses;

    public interface IMedicalManService
    {
        Task<PersistPersonalDataResponse> PersistPersonalData(PersistPersonalDataRequest request);

        Task<PersistOutpatientCardResponse> PersistOutpatientCard(PersistOutpatientCardRequest request);
    }
}
