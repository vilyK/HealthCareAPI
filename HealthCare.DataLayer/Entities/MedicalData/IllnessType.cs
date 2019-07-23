﻿namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class IllnessType : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int IllnessCategoryId { get; set; }

        [ForeignKey("IllnessCategoryId")]
        public IllnessCategory IllnessCategory { get; set; }

        public string OtherName { get; set; }
    }
}