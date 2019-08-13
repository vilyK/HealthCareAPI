namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;

    public interface IPatientService
    {
        Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);
    }
}