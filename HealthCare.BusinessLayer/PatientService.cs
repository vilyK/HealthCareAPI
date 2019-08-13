namespace HealthCare.BusinessLayer
{
    using System.Threading.Tasks;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    using Interfaces;

    public class PatientService : IPatientService
    {
        public Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
