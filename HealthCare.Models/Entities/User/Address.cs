namespace HealthCare.Models.DatabaseModels.User
{
    public class Address
    {
        public int Id { get; set; }

        public UserContact UserContact { get; set; }
        public int UserContactId { get; set; }

        public string BlockEntrance { get; set; }

        public string Entrance { get; set; }

        public int Floor { get; set; }

        public int FlatNumber { get; set; }

        public string StreetName { get; set; }

        public string StreetNumber { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }

        public bool IsCurrent { get; set; }
    }
}

