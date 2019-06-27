namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;

    public class MedicalManInfoPrice : SystemData
    {
        public int Id { get; set; }

        public int MedManInfoId { get; set; }
        public MedicalManInfo MedManInfo { get; set; }

        public int PriceTypeId { get; set; }
        public PriceType PriceType { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Value { get; set; }
    }

}
