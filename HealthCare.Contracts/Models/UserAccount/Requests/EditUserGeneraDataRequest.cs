namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using CommonModels;
    using Data;

    public class EditUserGeneraDataRequest
    {
        public int UserId { get; set; }

        public GeneralUserData GeneralData { get; set; }

        public ContactUserData Contacts { get; set; }
    }
}
