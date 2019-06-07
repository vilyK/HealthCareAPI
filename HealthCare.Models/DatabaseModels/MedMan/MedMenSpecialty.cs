namespace HealthCare.Models.DatabaseModels.MedMan
{
    public class MedMenSpecialty
    {
        public int Id { get; set; }

        public int MedMenInfoId { get; set; }
        public MedManInfo MedManInfo { get; set; }

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
