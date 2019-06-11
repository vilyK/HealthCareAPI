namespace HealthCare.Models.DatabaseModels.MedicalCenter
{
    using System.Collections.Generic;
    using User;

    public class MedicalCenterInfo
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        
        public string Name { get; set; }

        public string Details { get; set; }

        public bool IsNzok { get; set; }

        public bool HasEmergency { get; set; }

        public List<MedicalCenterDepartment> MedicalCenterDepartments = new List<MedicalCenterDepartment>();
    }
}
