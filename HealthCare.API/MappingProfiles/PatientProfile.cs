namespace HealthCare.API.MappingProfiles
{
    using AutoMapper;
    using Contracts.Models.PatientAccount.Data;
    using DataLayer.Entities.MedicalData;
    using DataLayer.Entities.Patient;

    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<PatientGeneralData, PatientInfo>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<MedicalProfileGeneralData, MedicalProfile>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
