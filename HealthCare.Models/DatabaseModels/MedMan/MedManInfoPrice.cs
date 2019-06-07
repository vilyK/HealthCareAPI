namespace HealthCare.Models.DatabaseModels.MedMan
{
    public class MedManInfoPrice
    {
        public int Id { get; set; }

        public int MedManInfoId { get; set; }
        public MedManInfo MedManInfo { get; set; }

        public int PriceTypeId { get; set; }
        public Price PriceType { get; set; }

        public decimal Value { get; set; }
    }

}
