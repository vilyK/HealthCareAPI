namespace HealthCare.DataLayer.Entities.MedicalCenter
{
    using Base;

    public class MedicalCenterDepartment : SystemData
    {
        public int Id { get; set; }

        public int MedicalCenterId { get; set; }
        public MedicalCenterInfo MedicalCenter { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
