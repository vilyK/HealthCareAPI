namespace HealthCare.API.Behaviour.Utils.AutoMapperProfiles
{
    using AutoMapper;
    using Contracts.Models.Appointment.Requests;
    using Contracts.Models.Common;
    using Contracts.Models.MedicalManAccount.Data;
    using DataLayer.Entities.MedicalMan;

    public class MedicalManProfile : Profile
    {
        public MedicalManProfile()
        {
            CreateMap<MedicalManGeneralData, MedicalManInfo>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));

            CreateMap<MedicalManInfo, CommonMedicalData>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember) => sourceMember != null));
           
            CreateMap<Specialty, SpecialtyData>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code));
            
            CreateMap<AppointmentHours, HourData>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember) => sourceMember != null));

            CreateMap<HourData, AppointmentHours>()
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember) => sourceMember != null));
        }
    }
}
