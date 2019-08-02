namespace HealthCare.Contracts.Models.Requests
{
    using CommonModels;
    using UserAccount.Data;

    public class RegisterUserRequest 
    {
        public int UserRole { get; set; }

        public ContactUserData Contacts { get; set; }

        public GeneralUserData GeneralData { get; set; }
    }
}
