namespace HealthCare.BusinessLayer.Services
{
    using System.Threading.Tasks;
    using Contracts.Models.Common;
    using Contracts.Models.OutpatientCard.Data;
    using Contracts.Models.OutpatientCard.Responses;
    using Interfaces;

    public class OutPatientCardService : IOutPatientCardService
    {
        public Task<TokenData> Add(OutPatientCardInfo request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GetOutPatientCardsResponse> GetAll(int patientId)
        {
            throw new System.NotImplementedException();
        }
    }
}
