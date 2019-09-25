namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Treatment : SystemData
    {
        public string Description { get; set; }

        public int? IllnessId { get; set; }

        [ForeignKey("IllnessId")]
        public Illness Illness { get; set; }

        public int? AllergyId { get; set; }

        [ForeignKey("AllergyId")]
        public Allergy Allergy { get; set; }

        public List<TreatmentMedicament> TreatmentMedicaments { get; set; }  = new List<TreatmentMedicament>();
    }
}
