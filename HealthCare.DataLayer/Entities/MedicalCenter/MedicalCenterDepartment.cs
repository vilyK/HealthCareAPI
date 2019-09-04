namespace HealthCare.DataLayer.Entities.MedicalCenter
{
    using Base;

    public class MedicalCenterDepartment : SystemData
    {
        public int MedicalCenterInfoId { get; set; }
        public MedicalCenterInfo MedicalCenterInfo { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
