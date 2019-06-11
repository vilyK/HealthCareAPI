namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using System.Collections.Generic;
    using MedMan;
    using Utilities.Enums;

    public class MedicalManInfo
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public DoctorType Type { get; set; }

        public bool IsNzok { get; set; } 

        public List<Award> Awards = new List<Award>();

        public List<MedicalMenSpecialty> Specialties = new List<MedicalMenSpecialty>();

        public List<MedicalManInfoPrice> Prices = new List<MedicalManInfoPrice>();
    }
}
