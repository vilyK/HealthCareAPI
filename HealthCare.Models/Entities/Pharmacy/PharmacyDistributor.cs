namespace HealthCare.DataLayer.Entities.Pharmacy
{
    using Base;
    using User;

    public class PharmacyDistributor : SystemData
    {
        public int Id { get; set; }

        public int PharmacyId { get; set; }
        public User Pharmacy { get; set; }

        public int DistributorId { get; set; }
        public User Distributor { get; set; }

    }
}
