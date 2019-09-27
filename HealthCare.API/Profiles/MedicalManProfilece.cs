﻿namespace HealthCare.API.Profiles
{
    using AutoMapper;

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

            CreateMap<AwardData, Award>()
                .ForMember(dest => dest.CreateDate, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition(
                    (source, destination, sourceMember, destMember) => sourceMember != null));
        }
    }
}
