namespace HealthCare.DataLayer.Entities.Pharmacy
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;
    using User;

    public class PharmacyInfo : SystemData, IInformation
    {
        public string Name { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User Pharmacy { get; set; }
    }
}
