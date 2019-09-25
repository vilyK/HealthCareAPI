namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Allergy : SystemData
    {
        public string Notes { get; set; }

        public int AllergyTypeId { get; set; }

        [ForeignKey("AllergyTypeId")]
        public AllergyType AllergyType { get; set; }        

        public int? MedicalProfileId { get; set; }

        [ForeignKey("MedicalProfileId")]
        public MedicalProfile MedicalProfile { get; set; }

        public int? OutpatientCardId { get; set; }

        [ForeignKey("OutpatientCardId")]
        public OutpatientCard OutpatientCard { get; set; }

        public List<Treatment> AllergyTreatments { get; set; }  = new List<Treatment>();
    }
}
