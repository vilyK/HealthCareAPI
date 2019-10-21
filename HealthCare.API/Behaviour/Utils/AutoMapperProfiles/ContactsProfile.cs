﻿namespace HealthCare.API.Behaviour.Utils.AutoMapperProfiles
{
    using AutoMapper;
    using Contracts.Models.UserAccount.Data;
    using DataLayer.Entities.UserAccount.Contacts;

    public class ContactsProfile : Profile
    {
        public ContactsProfile()
        {
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
        }
    }
}