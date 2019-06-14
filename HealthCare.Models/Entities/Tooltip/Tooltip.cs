namespace HealthCare.DataLayer.Entities.Tooltip
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Tooltip : SystemData
    {
        public int Id { get; set; }

        public int TooltipTypeId { get; set; }

        [ForeignKey("TooltipTypeId")]
        public TooltipType TooltipType { get; set; }

        public List<TooltipItem> TooltipItems { get; set; } = new List<TooltipItem>();
    }
}
