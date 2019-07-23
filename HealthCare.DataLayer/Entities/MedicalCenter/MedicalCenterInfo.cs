namespace HealthCare.DataLayer.Entities.MedicalCenter
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;

    public class MedicalCenterInfo : SystemData
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Details { get; set; }

        public bool IsNzok { get; set; }

        public bool HasEmergency { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<MedicalCenterDepartment> MedicalCenterDepartments { get; set; } = new List<MedicalCenterDepartment>();
    }
}
