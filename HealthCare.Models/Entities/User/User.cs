namespace HealthCare.Models.DatabaseModels.User
{
    using System.Collections.Generic;
    using Appointment;
    using Enums;
    using Notification;

    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public RoleType RoleType { get; set; }

        public int? ParentId { get; set; }
        public User Parent { get; set; }

        public List<Phone> Phones = new List<Phone>();

        public List<UserNotification> UsrNotifications = new List<UserNotification>();

        public List<NotificationTypeUser> NotificationTypeUsers = new List<NotificationTypeUser>();

        public List<Appointment> Appointments = new List<Appointment>();
    }
}
