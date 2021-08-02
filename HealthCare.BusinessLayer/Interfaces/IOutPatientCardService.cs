namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.Common;
    using Contracts.Models.OutpatientCard.Data;
    using Contracts.Models.OutpatientCard.Responses;

    public interface IOutPatientCardService
    {
        Task<TokenData> Add(OutPatientCardInfo request);

        Task<GetOutPatientCardsResponse> GetAll(int patientId);
    }
}