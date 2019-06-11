namespace HealthCare.Models.DatabaseModels.Patient
{
    using User;

    public class PatientInfo
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User Patient  { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
