namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Address : SystemData
    {
        public int Id { get; set; }

        public bool IsCurrent { get; set; }

        public string BlockEntrance { get; set; }

        public string Entrance { get; set; }

        public int Floor { get; set; }

        public int FlatNumber { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

        public int UserContactId { get; set; }

        [ForeignKey("UserContactId")]
        public UserContact UserContact { get; set; }
              
    }
}

