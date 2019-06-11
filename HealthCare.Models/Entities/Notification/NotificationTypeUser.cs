namespace HealthCare.Models.DatabaseModels.Notification
{
    using User;

    public class NotificationTypeUser
    {
        public int Id { get; set; }

        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

}
