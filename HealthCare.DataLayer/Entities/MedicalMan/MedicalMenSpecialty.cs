namespace HealthCare.DataLayer.Entities.MedicalMan
{
    using Base;

    public class MedicalMenSpecialty : SystemData
    {
        public int Id { get; set; }

        public int MedMenInfoId { get; set; }
        public MedicalManInfo MedManInfo { get; set; }

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
