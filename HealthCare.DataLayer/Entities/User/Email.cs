﻿namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;

    public class Email : SystemData, IContactIdentity
    {
        public int UserContactId { get; set; }

        [ForeignKey("UserContactId")]
        public UserContact UserContact { get; set; }      

        public string EmailAddress { get; set; }
    }
}
