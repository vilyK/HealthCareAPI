namespace HealthCare.Models.DatabaseModels.User
{
    using Enums;

    public class Phone
    {
        public int Id { get; set; }

        public int UserContactId { get; set; }
        public UserContact UserContact { get; set; }

        public PhoneType Type { get; set; }

        public string Number { get; set; }
}
}
