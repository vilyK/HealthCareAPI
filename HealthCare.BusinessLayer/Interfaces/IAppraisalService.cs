namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.Appraisal;

    public interface IAppraisalService
    {
        Task<SetAppraisalResponse> SetDoctorAppraisals(SetAppraisalRequest request);
    }
}
