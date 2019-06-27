namespace HealthCare.DataLayer.Entities.User
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;

    public class Photo : SystemData
    {
        public int Id { get; set; }
       
        public string Url { get; set; }

        public bool IsMain { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
