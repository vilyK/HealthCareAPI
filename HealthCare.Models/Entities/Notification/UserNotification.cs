namespace HealthCare.Models.DatabaseModels.Notification
{
    using User;

    public class UserNotification
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
        
    }
}
