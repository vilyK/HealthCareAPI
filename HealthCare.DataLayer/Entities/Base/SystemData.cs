namespace HealthCare.DataLayer.Entities.Base
{
    using System;

    public class SystemData
    {
        public bool IsDeleted { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
