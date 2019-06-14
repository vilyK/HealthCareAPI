namespace HealthCare.DataLayer.Entities.Patient
{
    using System.ComponentModel.DataAnnotations.Schema;

    using Base;
    using User;

    public class PatientInfo : SystemData
    {
        public int Id { get; set; }
       
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User Patient { get; set; }
    }
}
