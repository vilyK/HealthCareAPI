namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;

    using Contracts.Models.Requests;
    using Contracts.Models.Responses;

    public interface IUserService
    {
        Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);

        Task<LoginUserResponse> LoginUser(LoginUserRequest request);
    }
}