namespace HealthCare.Contracts.Interfaces
{
    using System.Collections.Generic;
    using Models.CommonMedicalData;

    public interface ITreatments
    {
        List<TreatmentData> Treatments { get; set; }
    }
}