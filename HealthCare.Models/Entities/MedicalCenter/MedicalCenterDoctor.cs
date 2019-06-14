namespace HealthCare.DataLayer.Entities.MedicalCenter
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;

    public class MedicalCenterDoctor : SystemData
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public User Doctor { get; set; }

        public int MedicalCenterId { get; set; }

        [ForeignKey("MedicalCenterId")]
        public User MedicalCenter { get; set; }

    }
}
