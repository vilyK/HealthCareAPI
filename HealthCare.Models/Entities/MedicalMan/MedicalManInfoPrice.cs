namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using MedMan;

    public class MedicalManInfoPrice
    {
        public int Id { get; set; }

        public int MedManInfoId { get; set; }
        public MedicalManInfo MedManInfo { get; set; }

        public int PriceTypeId { get; set; }
        public Price PriceType { get; set; }

        public decimal Value { get; set; }
    }

}
