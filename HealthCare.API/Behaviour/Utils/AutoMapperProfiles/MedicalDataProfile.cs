namespace HealthCare.API.Behaviour.Utils.AutoMapperProfiles
{
    using AutoMapper;
    using Contracts.Models.CommonMedicalData;
    using DataLayer.Entities.MedicalData;

    public class MedicalDataProfile : Profile
    {
        public MedicalDataProfile()
        {
            CreateMap<MedicalTestData, MedicalTest>()
                .ForMember(dest => dest.MedicalTestAttachments, opt => opt.Ignore())
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<AllergyData, Allergy>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<IllnessData, Illness>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<TreatmentData, Treatment>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForMember(dest => dest.TreatmentMedicaments, opt => opt.Ignore());
        }
    }
}
