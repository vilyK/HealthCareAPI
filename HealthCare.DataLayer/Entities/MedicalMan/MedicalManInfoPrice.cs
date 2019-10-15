namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;

    public class MedicalManPrice : SystemData
    {
        public int MedManInfoId { get; set; }

        [ForeignKey("MedManInfoId")]
        public MedicalManInfo MedManInfo { get; set; }

        public string PriceName { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Value { get; set; }
    }

}
