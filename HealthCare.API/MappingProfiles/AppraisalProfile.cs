namespace HealthCare.API.MappingProfiles
{
    using AutoMapper;

    using Contracts.Models.Appraisal;
    using DataLayer.Entities;

    public class AppraisalProfile : Profile
    {
        public AppraisalProfile()
        {
            CreateMap<AppraisalData, Appraisal>();
        }
    }
}
