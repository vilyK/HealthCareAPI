namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using PharmacyCompany;

    public class Medicament : SystemData
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public MedicamentCategory MedicamentCategory { get; set; }

        public int PharmacyCompanyInfoId { get; set; }

        [ForeignKey("PharmacyCompanyId")]
        public PharmacyCompanyInfo PharmacyCompanyInfo { get; set; }

        public List<TreatmentMedicament> TreatmentMedicaments { get; set; }  = new List<TreatmentMedicament>();
    }
}
