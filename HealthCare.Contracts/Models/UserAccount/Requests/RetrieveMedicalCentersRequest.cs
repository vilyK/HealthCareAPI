namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using Data;
    using Filters;

    public class RetrieveMedicalCentersRequest : CommonFilters
    {
        public DepartmentFilter Departments { get; set; }

        public bool HasEmergency { get; set; }
    }
}
