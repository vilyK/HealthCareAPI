namespace HealthCare.Contracts.Models.CommonMedicalData
{
    using System;
    using System.Collections.Generic;
    using Utilities.Enums;

    public class MedicalTestData
    {
        public string Results { get; set; }

        public DateTime MedicalTestDate { get; set; }

        public int MedicalCenterId { get; set; }

        public int MedicalTestTypeId { get; set; }

        public DocumentStatus Status { get; set; }

        public List<AttachmentData> MedicalTestAttachments { get; set; }
    }
}
