﻿namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;

    public class Address : SystemData, IContactIdentity
    {
        

        public string StreetAddress { get; set; }

        public bool IsCurrent { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        public int UserContactId { get; set; }

        [ForeignKey("UserContactId")]
        public UserContact UserContact { get; set; }
    }
}

