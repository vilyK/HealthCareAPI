namespace HealthCare.DataLayer.Entities.Pharmacy
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;

    public class PharmacyInfo : SystemData
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PharmacyId { get; set; }

        [ForeignKey("PharmacyId")]
        public User Pharmacy { get; set; }
    }
}
