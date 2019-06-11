namespace HealthCare.Models.DatabaseModels.Notification
{
    using System.Collections.Generic;

    public class NotificationType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<NotificationTypeUser> NotificationTypeUsers = new List<NotificationTypeUser>();
    }
}
