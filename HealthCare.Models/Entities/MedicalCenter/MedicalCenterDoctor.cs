namespace HealthCare.DataLayer.Entities.MedicalCenter
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;

    public class MedicalCenterDoctor : SystemData
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public User Doctor { get; set; }

        public int MedicalCenterId { get; set; }
        public User MedicalCenter { get; set; }

    }
}
