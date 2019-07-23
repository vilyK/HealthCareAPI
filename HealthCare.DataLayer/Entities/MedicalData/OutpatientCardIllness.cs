namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class OutpatientCardIllness : SystemData
    {
        public int Id { get; set; }

        public int IllnessId { get; set; }
        public Illness Illness { get; set; }

        public int OutpatientCardId { get; set; }
        public OutpatientCard OutpatientCard { get; set; }
    }
}
