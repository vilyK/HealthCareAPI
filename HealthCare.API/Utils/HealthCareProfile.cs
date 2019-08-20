namespace HealthCare.API.Utils
{
    using AutoMapper;

    using Contracts.Models.UserAccount.Data;
    using Contracts.Models.UserAccount.Requests;
    using DataLayer.Entities.User;

    public class HealthCareProfile : Profile
    {
        public HealthCareProfile()
        {
            CreateMap<RegisterUserRequest, User>();

            CreateMap<EmailData, Email>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => (sourceMember != null)));

            CreateMap<AddressData, Address>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => (sourceMember != null)));

            CreateMap<PhoneData, Phone>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => (sourceMember != null)));

            //CreateMap<PhotoData, Photo>()
            //    .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
            //    .ForAllMembers(opt => opt.Condition(
            //        (source, destination, sourceMember, destMember) => (sourceMember != null)));
        }
    }
}
