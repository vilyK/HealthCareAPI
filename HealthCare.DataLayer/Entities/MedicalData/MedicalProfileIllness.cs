namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class MedicalProfileIllness : SystemData
    {
        public int IllnessId { get; set; }
        public Illness Illness { get; set; }

        public int MedicalProfileId { get; set; }
        public MedicalProfile MedicalProfile { get; set; }
    }
}
