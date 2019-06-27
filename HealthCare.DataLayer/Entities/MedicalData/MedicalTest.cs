namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using MedicalCenter;
    using Utilities.Enums;

    public class MedicalTest : SystemData
    {
        public int Id { get; set; }

        public string Results { get; set; }

        public DateTime MedicalTestDate { get; set; }

        public int MedicalCenterId { get; set; }

        [ForeignKey("MedicalCenterId")]
        public MedicalCenterInfo MedicalCenter { get; set; }
             
        public int MedicalTestTypeId { get; set; }

        [ForeignKey("MedicalTestTypeId")]
        public MedicalTestType MedicalTestType { get; set; }

        public DocumentStatus Status { get; set; }

        public List<OutpatientCardMedicalTest> OutpatientCardMedicalTests { get; set; } = new List<OutpatientCardMedicalTest>();

        public List<MedicalProfileMedicalTest> MedicalProfileMedicalTests { get; set; } = new List<MedicalProfileMedicalTest>();

        public List<MedicalTestAttachment> MedicalTestAttachments { get; set; }  = new List<MedicalTestAttachment>();
    }
}
