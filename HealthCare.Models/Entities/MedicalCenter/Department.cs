namespace HealthCare.Models.DatabaseModels.MedicalCenter
{
    using System.Collections.Generic;

    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedicalCenterDepartment> MedicalCenterDepartments = new List<MedicalCenterDepartment>();
    }
}
