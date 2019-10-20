namespace HealthCare.DataLayer.Entities.Pharmacy
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;
    using UserAccount;

    public class PharmacyDistributor : SystemData
    {
        public int PharmacyId { get; set; }

        [ForeignKey("PharmacyId")]
        public User Pharmacy { get; set; }

        public int DistributorId { get; set; }

        [ForeignKey("DistributorId")]
        public User Distributor { get; set; }

    }
}
