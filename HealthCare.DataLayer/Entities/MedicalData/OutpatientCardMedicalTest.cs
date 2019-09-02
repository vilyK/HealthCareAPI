namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class OutpatientCardMedicalTest : SystemData
    {
        

        public int MedicalTestId { get; set; }
        public MedicalTest MedicalTest { get; set; }

        public int OutpatientCardId { get; set; }
        public OutpatientCard OutpatientCard { get; set; }
    }
}
