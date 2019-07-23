﻿namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class City : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AreaId { get; set; }

        [ForeignKey("AreaId")]
        public Area Area { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]

        public Country Country { get; set; }
    }
}