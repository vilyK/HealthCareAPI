namespace HealthCare.Models.DatabaseModels.Patient
{
    using System;
    using Utilities.Enums;

    public class MedicalProfile
    {
        public int Id { get; set; }

        public int PatientInfoId { get; set; }
        public PatientInfo PatientInfo { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public DateTime BirthDate { get; set; }

        public Level PhysicalActivityLevel { get; set; }

        public Level StressLevel { get; set; }

        public BloodGroup BloodGroup { get; set; }
    }
}
