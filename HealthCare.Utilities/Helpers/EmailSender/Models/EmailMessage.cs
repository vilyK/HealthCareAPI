namespace HealthCare.Utilities.Helpers.EmailSender.Models
{
    using System.Collections.Generic;
    using Interfaces.EmailModels;

    public class EmailMessage
    {
        public string Subject { get; set; }

        public EmailAddress FromAddress { get; set; } = new EmailAddress();

        public List<EmailAddress> ToAddresses { get; set; } = new List<EmailAddress>();

    }
}
