namespace HealthCare.Contracts.Models.Appraisal
{
    using System.Collections.Generic;
    using Utilities.Enums;

    public class SetAppraisalRequest
    {
        public int RecipientId { get; set; }

        public AppraisalRecipientType RecipientType { get; set; }

        public List<AppraisalData> Appraisals { get; set; }
    }
}
