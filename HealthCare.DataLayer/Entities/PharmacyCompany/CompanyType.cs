namespace HealthCare.DataLayer.Entities.PharmacyCompany
{
    using System.Collections.Generic;

    using Base;

    public class CompanyType : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PharmacyCompanyType> PharmacyCompanyTypes { get; set; } = new List<PharmacyCompanyType>();
    }
}
