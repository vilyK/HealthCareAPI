﻿namespace HealthCare.DataLayer.Entities.Notification
{
    using Base;
    using User;

    public class NotificationUser : SystemData
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int NotificationId { get; set; }
        public Notification Notification { get; set; }       
    }
}