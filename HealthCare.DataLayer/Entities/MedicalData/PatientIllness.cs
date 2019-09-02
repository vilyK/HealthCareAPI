namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Utilities.Enums;

    public class PatientIllness : SystemData
    {
        

        public int IllnessTypeId { get; set; }

        [ForeignKey("IllnessTypeId")]
        public IllnessType IllnessType { get; set; }

        public IllnessPeriod IllnessPeriod { get; set; }

        public DocumentStatus Status { get; set; }

        public List<OutpatientCardIllness> OutpatientCardIllnesses { get; set; } = new List<OutpatientCardIllness>();

        public List<MedicalProfileIllness> MedicalProfileIllnesses { get; set; }  = new List<MedicalProfileIllness>();

        public List<IllnessTreatment> IllnessTreatments { get; set; }  = new List<IllnessTreatment>();
    }
}
