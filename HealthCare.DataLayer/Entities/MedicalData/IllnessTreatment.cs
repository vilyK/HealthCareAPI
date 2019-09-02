namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class IllnessTreatment : SystemData
    {
        public int IllnessId { get; set; }
        public Illness Illness { get; set; }

        public int TreatmentId { get; set; }
        public Treatment Treatment { get; set; }
    }
}
