namespace HealthCare.API.Behaviour.Utils.AutoMapperProfiles
{
    using AutoMapper;
    using Contracts.Models.MedicalCenterAccount.Data;
    using DataLayer.Entities.MedicalCenter;

    public class MedicalCenterProfile : Profile
    {
        public MedicalCenterProfile()
        {
            CreateMap<MedicalCenterData, MedicalCenterInfo>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForMember(dest => dest.MedicalCenterDepartments, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));
        }
    }
}
