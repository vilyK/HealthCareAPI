namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Allergy : SystemData
    {
        public int Id { get; set; }

        public string Notes { get; set; }

        public int AllergyTypeId { get; set; }

        [ForeignKey("AllergyTypeId")]
        public AllergyType AllergyType { get; set; }        

        public List<OutpatientCardAllergy> OutpatientCardAllergies { get; set; } = new List<OutpatientCardAllergy>();

        public List<MedicalProfileAllergy> MedicalProfileAllergies { get; set; } = new List<MedicalProfileAllergy>();

        public List<AllergyTreatment> AllergyTreatments { get; set; }  = new List<AllergyTreatment>();
    }
}
