namespace HealthCare.Models.DatabaseModels.MedMan
{
    using System.Collections.Generic;
    using Enums;

    public class MedManInfo
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public DoctorType Type { get; set; }

        public bool IsNzok { get; set; } 

        public List<Award> Awards = new List<Award>();

        public List<MedMenSpecialty> Specialties = new List<MedMenSpecialty>();

        public List<MedManInfoPrice> Prices = new List<MedManInfoPrice>();
    }
}
