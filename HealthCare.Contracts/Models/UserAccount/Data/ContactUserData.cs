namespace HealthCare.Contracts.Models.UserAccount.Data
{
    using System.Collections.Generic;

    public class ContactUserData
    {
        public List<EmailData> Emails { get; set; }

        public List<PhoneData> Phones { get; set; }

        public List<AddressData> Addresses { get; set; }
    }
}
