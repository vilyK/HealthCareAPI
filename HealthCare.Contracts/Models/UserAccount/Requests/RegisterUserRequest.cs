namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using Data;

    public class RegisterUserRequest 
    {
        public int UserRole { get; set; }

        public string Name { get; set; }
        public ContactUserData Contacts { get; set; }

        public GeneralUserData GeneralData { get; set; }
    }
}
