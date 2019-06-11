namespace HealthCare.Models.DatabaseModels.Notification
{
    using System;
    using System.Collections.Generic;
    using Utilities.Enums;

    public class Notification
    {
        public int Id { get; set; }

        public NotificationReason ReasonType { get; set; }

        public DateTime NotificationDate { get; set; }

        public List<UserNotification> UsrNotifications = new List<UserNotification>();
    }
}
