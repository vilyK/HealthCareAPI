﻿namespace HealthCare.Contracts.Models.Correspondence.Requests
{
    using Utilities.Helpers.EmailSender.Models;

    public class SendEmailRequest
    {
        public EmailMessage Message { get; set; }
    }
}
