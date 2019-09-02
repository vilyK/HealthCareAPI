namespace HealthCare.DataLayer.Entities.Tooltip
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class TooltipItem : SystemData
    {
        

        public string Title { get; set; }

        public string Text { get; set; }

        public int Order { get; set; }

        public int TooltipId { get; set; }

        [ForeignKey("TooltipId")]
        public Tooltip Tooltip { get; set; }
    }
}
