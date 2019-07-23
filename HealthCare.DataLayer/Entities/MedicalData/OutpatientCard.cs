namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;
    using Utilities.Enums;

    public class OutpatientCard : SystemData
    {
        public int Id { get; set; }      

        public string Results { get; set; }

        public DocumentStatus Status { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public User Patient { get; set; }

        public List<OutpatientCardMedicalTest> OutpatientCardMedicalTests { get; set; }  = new List<OutpatientCardMedicalTest>();

        public List<OutpatientCardIllness> OutpatientCardIllnesses { get; set; }  = new List<OutpatientCardIllness>();

        public List<OutpatientCardAllergy> OutpatientCardAllergies { get; set; }  = new List<OutpatientCardAllergy>();
    }
}
