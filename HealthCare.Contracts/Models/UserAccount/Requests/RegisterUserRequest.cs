namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using CommonModels;
    using Data;

    public class RegisterUserRequest 
    {
        public int UserRole { get; set; }

        public ContactUserData Contacts { get; set; }

        public GeneralUserData GeneralData { get; set; }
    }
}
