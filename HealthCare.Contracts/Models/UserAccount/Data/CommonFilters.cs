namespace HealthCare.Contracts.Models.UserAccount.Data
{
    using System.Collections.Generic;
    using Filters;

    public class CommonFilters
    {
        public CityFilter Cities { get; set; }

        public RegionFilter Regions { get; set; }

        public List<RatingFilter> Ratings { get; set; }
    }
}
