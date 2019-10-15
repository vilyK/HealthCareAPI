namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;
    using User;
    using Utilities.Enums;

    public class MedicalManInfo : SystemData, IInformation
    {
        public string Name { get; set; }

        public string Biography { get; set; }

        public DoctorType Type { get; set; }

        public bool IsNzok { get; set; }

        public bool IsAdditionalHealthInsurance { get; set; }

        public int ExperienceInYears { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public List<Award> Awards = new List<Award>();

        public List<MedicalMenSpecialty> Specialties { get; set; } = new List<MedicalMenSpecialty>();

        public List<MedicalManPrice> Prices { get; set; } = new List<MedicalManPrice>();
    }
}
