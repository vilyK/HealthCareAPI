namespace HealthCare.Contracts.Models.Correspondence.Requests
{
    using Data;

    public class SendEmailRequest
    {
        public EmailAddress ToAddress { get; set; }

        public EmailAddress FromAddress { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
