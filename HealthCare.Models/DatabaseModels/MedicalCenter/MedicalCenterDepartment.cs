namespace HealthCare.Models.DatabaseModels.MedicalCenter
{
    public class MedicalCenterDepartment
    {
        public int Id { get; set; }

        public int MedicalCenterId { get; set; }
        public MedicalCenterInfo MedicalCenter { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
