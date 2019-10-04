namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.Correspondence.Requests;
    using Contracts.Models.Correspondence.Responses;

    public interface ICorrespondenceService
    {
        Task<SendEmailResponse> SendEmail(SendEmailRequest request);
    }
}
