namespace HealthCare.Models.DatabaseModels.User
{
    public class Email
    {
        public int Id { get; set; }

        public int UserContactId { get; set; }
        public UserContact UserContact { get; set; }      

        public string EmailAddress { get; set; }
    }
}
