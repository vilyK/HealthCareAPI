namespace HealthCare.DataLayer.Entities.MedicalCenter
{
    using System.Collections.Generic;

    using Base;

    public class Department : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedicalCenterDepartment> MedicalCenterDepartments { get; set; } = new List<MedicalCenterDepartment>();
    }
}
