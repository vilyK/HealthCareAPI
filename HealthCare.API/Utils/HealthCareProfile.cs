namespace HealthCare.API.Utils
{
    using AutoMapper;
    using Contracts.Models.MedicalCenterAccount.Data;
    using Contracts.Models.MedicalManAccount.Data;
    using Contracts.Models.PatientAccount.Data;
    using Contracts.Models.UserAccount.Data;
    using Contracts.Models.UserAccount.Requests;
    using Contracts.Models.UserAccount.Responses;
    using DataLayer.Entities.MedicalCenter;
    using DataLayer.Entities.MedicalData;
    using DataLayer.Entities.MedicalMan;
    using DataLayer.Entities.Patient;
    using DataLayer.Entities.User;

    public class HealthCareProfile : Profile
    {
        public HealthCareProfile()
        {
            CreateMap<RegisterUserRequest, User>();

            // Contact Related Mappings

            CreateMap<EmailData, Email>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<AddressData, Address>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<PhoneData, Phone>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));


            // MedicalMen Related Data Mappings

            CreateMap<MedicalManGeneralData, MedicalManInfo>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<AwardData, Award>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));


            // Patient Related Data Mappings

            CreateMap<PatientGeneralData, PatientInfo>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<MedicalProfileGeneralData, MedicalProfile>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));


            // Medical Data Mappings

            CreateMap<MedicalTestData, MedicalTest>()
                .ForMember(dest => dest.MedicalTestAttachments, opt => opt.Ignore())
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            //CreateMap<AttachmentData, MedicalTestAttachment>()
            //    .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
            //    .ForAllMembers(opt => opt.Condition(
            //        (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<AllergyData, MedicalProfileAllergy>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<IllnessData, MedicalProfileIllness>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            // Medical Center Data Mappings
            CreateMap<MedicalCenterData, MedicalCenterInfo>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForMember(dest => dest.MedicalCenterDepartments, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            // Search Requests Related Data mappings

            CreateMap<User, RetrieveDoctorsResponse>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Contacts, opt => opt.MapFrom(src => src.UserContact))
                    .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.MedicalManInfo.Biography));
        }

    }
}
