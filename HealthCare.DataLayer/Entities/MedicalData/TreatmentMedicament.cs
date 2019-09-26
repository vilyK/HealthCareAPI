namespace HealthCare.DataLayer.Entities.MedicalData
{
    using Base;

    public class TreatmentMedicament : SystemData
    {
        public int TreatmentId{ get; set; }
        public Treatment Treatment { get; set; }

        public int MedicamentId { get; set; }
        public Medicament Medicament { get; set; }

        public string Description { get; set; }
    }
}
