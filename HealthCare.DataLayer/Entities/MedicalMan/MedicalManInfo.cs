namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;
    using Utilities.Enums;

    public class MedicalManInfo : SystemData
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public DoctorType Type { get; set; }

        public bool IsNzok { get; set; } 

        public int MedicalCenterId { get; set; }

        [ForeignKey("MedicalCenterId")]
        public User MedicalCenter { get; set; }

        public List<Award> Awards = new List<Award>();

        public List<MedicalMenSpecialty> Specialties { get; set; } = new List<MedicalMenSpecialty>();

        public List<MedicalManInfoPrice> Prices { get; set; } = new List<MedicalManInfoPrice>();
    }
}
