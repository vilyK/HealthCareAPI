namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;

    using Contracts.Models.Appraisal.Requests;
    using Contracts.Models.Appraisal.Responses;

    public interface IAppraisalService
    {
        Task<SetAppraisalResponse> GiveAppraisals(SetAppraisalRequest request);
    }
}
