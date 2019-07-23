namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Email : SystemData
    {
        public int Id { get; set; }

        public int UserContactId { get; set; }

        [ForeignKey("UserContactId")]
        public UserContact UserContact { get; set; }      

        public string EmailAddress { get; set; }
    }
}
