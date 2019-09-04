namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class MedicalProfileMedicalTest : SystemData
    {

        public int MedicalTestId { get; set; }
        public MedicalTest MedicalTest { get; set; }

        public int MedicalProfileId { get; set; }
        public MedicalProfile MedicalProfile { get; set; }
    }
}
