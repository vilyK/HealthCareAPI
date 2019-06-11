namespace HealthCare.Models.DatabaseModels.MedicalMan
{
    using MedMan;

    public class MedicalMenSpecialty
    {
        public int Id { get; set; }

        public int MedMenInfoId { get; set; }
        public MedicalManInfo MedManInfo { get; set; }

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
