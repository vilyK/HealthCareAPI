namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using System.Collections.Generic;

    public class Specialty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedicalMenSpecialty> MedMan = new List<MedicalMenSpecialty>();
    }
}
