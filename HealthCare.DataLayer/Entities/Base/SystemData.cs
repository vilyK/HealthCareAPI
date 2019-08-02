namespace HealthCare.DataLayer.Entities.Base
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SystemData
    {
        [Column(Order = 1000)]
        public bool IsDeleted { get; set; }

        [Column(Order = 1001)]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Column(Order = 1002)]
        public DateTime UpdateDate { get; set; }
    }
}
