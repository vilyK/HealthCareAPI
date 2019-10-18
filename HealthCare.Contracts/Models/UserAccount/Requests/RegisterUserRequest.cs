namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using Data;
    using Utilities.Enums;

    public class RegisterUserRequest 
    {
        public string Name { get; set; }

        public RoleType UserRole { get; set; }

        public ContactUserData Contacts { get; set; }

        public GeneralUserData GeneralData { get; set; }
    }
}
