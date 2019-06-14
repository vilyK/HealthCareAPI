namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using System.Collections.Generic;
    using Base;

    public class Specialty : SystemData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<MedicalMenSpecialty> MedicalMan { get; set; } = new List<MedicalMenSpecialty>();
    }
}
