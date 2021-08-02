namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using Data;
    using HealthCare.Interfaces;
    using Utilities.Enums;

    public class RegisterUserRequest : IName
    {
        public GeneralUserData GeneralData { get; set; }

        public string Name { get; set; }

        public RoleType UserRole { get; set; }

        public long EGN { get; set; }

        public RegisterContactData Contacts { get; set; }
    }
}
