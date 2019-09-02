namespace HealthCare.DataLayer.Entities.Tooltip
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Base;

    public class TooltipPhoto : SystemData
    {
        

        public string Url { get; set; }

        public int ToolTipItemId { get; set; }


        [ForeignKey("ToolTipItemId")]
        public TooltipItem TooltipItem { get; set; }
    }
}
