namespace HealthCare.API.MappingProfiles
{
    using AutoMapper;

    using Contracts.Models.Appraisal;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    using DataLayer.Entities;
    using DataLayer.Entities.User;

    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            CreateMap<RegisterUserRequest, User>();

            // Search Requests Related Data mappings
            CreateMap<User, RetrieveDoctorsResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Contacts, opt => opt.MapFrom(src => src.UserContact))
                .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.MedicalManInfo.Biography));
        }
    }
}
