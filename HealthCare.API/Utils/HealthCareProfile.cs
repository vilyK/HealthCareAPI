namespace HealthCare.API.Utils
{
    using AutoMapper;
    using Contracts.Models.UserAccount.Requests;
    using DataLayer.Entities.User;

    public class HealthCareProfile : Profile
    {
        public HealthCareProfile()
        {
            CreateMap<RegisterUserRequest, User>();
        }
    }
}
