namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using Data;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public class RegisterUserRequest : IName
    {
        public string Name { get; set; }

        public RoleType UserRole { get; set; }

        public ContactUserData Contacts { get; set; }

        public GeneralUserData GeneralData { get; set; }
    }
}
