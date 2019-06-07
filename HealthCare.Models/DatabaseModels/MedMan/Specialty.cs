namespace HealthCare.Models.DatabaseModels.MedMan
{
    using System.Collections.Generic;

    public class Specialty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedMenSpecialty> MedMan = new List<MedMenSpecialty>();
    }
}
