namespace HealthCare.DataLayer.Entities.PharmacyCompany
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;
    using User;

    public class PharmacyCompanyInfo : SystemData, IInformation
    {
        public string Name { get; set; }

        public string Details { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User PharmacyCompany { get; set; }
       
        public List<PharmacyCompanyType> PharmacyCompanyTypes { get; set; } = new List<PharmacyCompanyType>();
    }
}
