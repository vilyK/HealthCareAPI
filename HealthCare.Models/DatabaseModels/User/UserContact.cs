namespace HealthCare.Models.DatabaseModels.User
{
    using System.Collections.Generic;

    public class UserContact
    {
        public int Id { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public List<Email> Emails = new List<Email>();

        public List<Address> Addresses = new List<Address>();

        public List<Phone> Phones = new List<Phone>();

    }
}
