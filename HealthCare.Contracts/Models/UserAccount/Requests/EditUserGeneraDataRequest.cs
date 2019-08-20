﻿namespace HealthCare.Contracts.Models.UserAccount.Requests
{
    using System.Collections.Generic;
    using Data;

    public class EditUserGeneraDataRequest
    {
        public GeneralUserData GeneralData { get; set; }

        public ContactUserData Contacts { get; set; }

        public List<ImageData> Images { get; set; }
    }
}
