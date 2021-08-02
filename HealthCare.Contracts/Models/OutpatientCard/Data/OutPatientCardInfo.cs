namespace HealthCare.Contracts.Models.OutpatientCard.Data
{
    using System;
    using System.Collections.Generic;
    using CommonMedicalData;
    using Microsoft.AspNetCore.Http;
    using Utilities.Enums.Visitation;

    public class OutPatientCardInfo
    {
        public int Id {get; set; }

        public string DoctorName { get; set; } = "Ivan Ivanov";

        public string DoctorSpecialty { get; set; } = "Test Specialty";

        public string SpecialtyCode { get; set; } = "01";

        public int PatientId { get; set; }

        public int MedicalCenterId { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string FinancedBy { get; set; }

        public VisitationReason VisitationReason { get; set; }

        public VisitationType VisitationType { get; set; }

        public List<MedicalDocuments> MedicalDocuments { get; set; }

        public List<MedicalDocuments> MedicalDocumentsVSD { get; set; }

        public List<MedicalDocumentsMMD> MedicalDocumentsMMD { get; set; }

        public int MECardNumber { get; set; }

        public MedicalDocumentsKP MedicalDocumentsKP { get; set; }

        public SickLeave SickLeave { get; set; }

        public int PrescriptionBookId { get; set; }

        public bool QuickTest { get; set; }

        public bool StageEpicrisis { get; set; }

        public bool MedicalNote { get; set; }

        public bool Prescription { get; set; }

        public int MainDiagnoseId { get; set; }

        public int MainDiagnoseCategoryId { get; set; }

        public string MainDiagnoseName { get; set; }

        public List<int> OtherDiseases { get; set; }

        public string MedicalHistory { get; set; }

        public string ObjectiveCondition { get; set; }

        public string Therapies { get; set; }

        public List<AttachmentData> MedicalAttachments { get; set; }
    }

    public class MedicalDocuments
    {
        public int CodeSpecialist { get; set; }

        public int DocumentNumber { get; set; }
    }

    public class MedicalDocumentsVSD : MedicalDocuments
    {
        public int VSDCode { get; set; }
    }

    public class MedicalDocumentsMMD
    {
        public int DocumentNumber { get; set; }

        public int CodeTests1 { get; set; }

        public int CodeTests2 { get; set; }

        public int CodeTests3 { get; set; }


        public int CodeTests4 { get; set; }
    }

    public class MedicalDocumentsKP
    {
        public int CodeSpecialist { get; set; }

        public int CardTelk { get; set; }
    }

    public class SickLeave
    {
        public int DocumentNumber { get; set; }

        public int DaysCount { get; set; }

        public string MKBCode { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

