namespace HealthCare.DataLayer.Entities.Event
{
    using System;
    using Base;

    public class Event : SystemData
    {
        
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public string Location { get; set; }

        public string Website { get; set; }

        public string Description { get; set; }
    }
}
