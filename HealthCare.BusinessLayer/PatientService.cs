namespace HealthCare.BusinessLayer
{
    using System.Threading.Tasks;
    using Contracts.Models.Requests;
    using Contracts.Models.Responses;
    using Interfaces;

    public class PatientService : IPatientService
    {
        public Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
