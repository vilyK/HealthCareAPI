namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using Interfaces;
    using Utilities.Enums;

    public class Phone : SystemData, IIdentity
    {
        public int Id { get; set; }

        public PhoneType Type { get; set; }

        public string Number { get; set; }

        public int UserContactId { get; set; }

        [ForeignKey("UserContactId")]
        public UserContact UserContact { get; set; }

    }
}
