﻿namespace HealthCare.DataLayer.Entities.Pharmacy
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;
    using User;

    public class PharmacyDistributor : SystemData
    {
        public int Id { get; set; }

        public int PharmacyId { get; set; }

        [ForeignKey("PharmacyId")]
        public User Pharmacy { get; set; }

        public int DistributorId { get; set; }

        [ForeignKey("DistributorId")]
        public User Distributor { get; set; }

    }
}