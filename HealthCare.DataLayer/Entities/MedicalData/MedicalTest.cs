namespace HealthCare.DataLayer.Entities.MedicalData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;
    using MedicalCenter;
    using Utilities.Enums;

    public class MedicalTest : SystemData, IMedicalData
    {
        public string Results { get; set; }

        public string Notes { get; set; }

        public DateTime MedicalTestDate { get; set; }

        public int? MedicalCenterId { get; set; }

        [ForeignKey("MedicalCenterId")]
        public MedicalCenterInfo MedicalCenter { get; set; }
             
        public int MedicalTestTypeId { get; set; }

        [ForeignKey("MedicalTestTypeId")]
        public MedicalTestType MedicalTestType { get; set; }

        public int? MedicalProfileId { get; set; }

        [ForeignKey("MedicalProfileId")]
        public MedicalProfile MedicalProfile { get; set; }

        public int? OutpatientCardId { get; set; }

        [ForeignKey("OutpatientCardId")]
        public OutpatientCard OutpatientCard { get; set; }

        public DocumentStatus Status { get; set; }

        public List<MedicalTestAttachment> MedicalTestAttachments { get; set; }  = new List<MedicalTestAttachment>();
    }
}
