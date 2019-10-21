namespace HealthCare.BusinessLayer.Interfaces
{
    using System.Threading.Tasks;

    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;

    public interface IUserService
    {
        Task<RegisterUserResponse> RegisterUser(RegisterUserRequest request);

        Task<LoginUserResponse> LoginUser(LoginUserRequest request);

        Task<AddContactResponse> AddContact(AddContactRequest request);

        Task<EditUserGeneraDataResponse> EditGeneralData(EditUserGeneraDataRequest request);

        Task<UploadImagesResponse> UploadImages(UploadImagesRequest request);

        Task<RetrieveDoctorsResponse> RetrieveDoctors(RetrieveDoctorsRequest request);

        Task<RetrieveMedicalCentersResponse> RetrieveMedicalCenters(RetrieveMedicalCentersRequest request);
    }
}