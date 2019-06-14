namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Award : SystemData
    {
        public int Id { get; set; }
     
        public string Name { get; set; }

        public DateTime Year { get; set; }

        public string AdditionalInfo { get; set; }

        public int MedManInfoId { get; set; }

        [ForeignKey("MedManInfoId")]
        public MedicalManInfo MedManInfo { get; set; }
    }
}
