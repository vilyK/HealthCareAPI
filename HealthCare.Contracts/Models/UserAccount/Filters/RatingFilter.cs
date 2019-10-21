namespace HealthCare.Contracts.Models.UserAccount.Filters
{
    using Utilities.Enums;

    public class RatingFilter
    {
        public AppraisalType Appraisal { get; set; }

        public int Value { get; set; }
    }
}
