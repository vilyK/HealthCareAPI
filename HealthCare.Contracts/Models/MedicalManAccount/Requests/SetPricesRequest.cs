namespace HealthCare.Contracts.Models.MedicalManAccount.Requests
{
    using System.Collections.Generic;
    using Data;

    public class SetPricesRequest
    {
        public List<PriceData> Prices { get; set; }
    }
}
