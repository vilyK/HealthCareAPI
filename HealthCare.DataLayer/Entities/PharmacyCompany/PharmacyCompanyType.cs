namespace HealthCare.DataLayer.Entities.PharmacyCompany
{
    using Base;

    public class PharmacyCompanyType : SystemData
    {
       public int Id { get; set; }

       public int PharmacyCompanyInfoId { get; set; }
       public PharmacyCompanyInfo PharmacyCompanyInfo { get; set; }

       public int CompanyTypeId { get; set; }
       public CompanyType CompanyType { get; set; }
    }
}
