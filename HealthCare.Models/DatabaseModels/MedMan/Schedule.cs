namespace HealthCare.Models.DatabaseModels.MedMan
{
    using System;

    public class Schedule
    {
        public int Id { get; set; }

        //public int MedMedId { get; set; }
        // public User UserdId {get;set;}
        public DateTime Date { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
