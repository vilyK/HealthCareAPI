namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using UserAccount;
    using Utilities.Enums;

    public class OutpatientCard : SystemData
    {
        public DocumentStatus Status { get; set; }

        public string Notes { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public User Patient { get; set; }

        public List<MedicalTest> OutpatientCardMedicalTests { get; set; }  = new List<MedicalTest>();

        public List<Illness> OutpatientCardIllnesses { get; set; }  = new List<Illness>();

        public List<Allergy> OutpatientCardAllergies { get; set; }  = new List<Allergy>();
    }
}
