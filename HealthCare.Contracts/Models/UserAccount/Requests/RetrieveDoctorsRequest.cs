namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using Data;
    using Filters;

    public class RetrieveDoctorsRequest : CommonFilters
    {
        public CategoryFilter DoctorCategories { get; set; }

        public bool IsAdditionalHealthInsurance { get; set; }

        public ExperienceFilter Experience { get; set; }

        public bool WorkingWithNzok { get; set; }
    }
}
