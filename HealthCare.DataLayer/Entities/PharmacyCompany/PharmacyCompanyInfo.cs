namespace HealthCare.DataLayer.Entities.PharmacyCompany
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;

    public class PharmacyCompanyInfo : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public int PharmacyCompanyId { get; set; }

        [ForeignKey("PharmacyCompanyId")]
        public User PharmacyCompany { get; set; }
       
        public List<PharmacyCompanyType> PharmacyCompanyTypes { get; set; } = new List<PharmacyCompanyType>();
    }
}
