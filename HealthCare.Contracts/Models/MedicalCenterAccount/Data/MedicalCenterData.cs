namespace HealthCare.Contracts.Models.MedicalCenterAccount.Data
{
    using System.Collections.Generic;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public class MedicalCenterData : IName
    {
        public string Name { get; set; }

        public MedicalCenterType Type { get; set; }

        public string Details { get; set; }

        public bool IsNzok { get; set; }

        public bool HasEmergency { get; set; }

        public List<int> MedicalCenterDepartments { get; set; } = new List<int>();
    }
}
