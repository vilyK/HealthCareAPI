namespace HealthCare.Contracts.Models.MedicalCenterAccount.Data
{
    using System.Collections.Generic;
    using Utilities.Enums;

    public class MedicalCenterData
    {
        public string Name { get; set; }

        public MedicalCenterType Type { get; set; }

        public string Details { get; set; }

        public bool IsNzok { get; set; }

        public bool HasEmergency { get; set; }

        public List<int> MedicalCenterDepartments { get; set; } = new List<int>();
    }
}
