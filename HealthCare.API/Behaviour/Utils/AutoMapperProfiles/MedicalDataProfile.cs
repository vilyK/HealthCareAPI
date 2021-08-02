namespace HealthCare.API.Behaviour.Utils.AutoMapperProfiles
{
    using AutoMapper;
    using Contracts.Models.Common;
    using Contracts.Models.CommonMedicalData;
    using Contracts.Models.OutpatientCard.Data;
    using DataLayer.Entities.MedicalData;

    public class MedicalDataProfile : Profile
    {
        public MedicalDataProfile()
        {
            CreateMap<AttachmentData, MedicalTest>()
                .ForMember(dest => dest.MedicalTestAttachments, opt => opt.Ignore())
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<IllnessData, Illness>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<IllnessType, CommonMedicalData>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<IllnessCategory, CommonMedicalData>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember) => sourceMember != null));

            CreateMap<OutpatientCard, OutPatientCardInfo>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<OutPatientCardInfo, OutpatientCard>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));
        }
    }
}
