namespace HealthCare.BusinessLayer.Services
{
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;

    using Contracts.Configuration;
    using Contracts.Models.Correspondence.Requests;
    using Contracts.Models.Correspondence.Responses;
    using Interfaces;
    using Microsoft.Extensions.Options;

    public class CorrespondenceService : ICorrespondenceService
    {
        private readonly IOptionsSnapshot<EmailConfiguration> _emailConfig;

        public CorrespondenceService(IOptionsSnapshot<EmailConfiguration> emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public async Task<SendEmailResponse> SendEmail(SendEmailRequest request)
        {
            var smtpClient = new SmtpClient
            {
                Host = _emailConfig.Value.SmtpHost,
                Port = _emailConfig.Value.SmtpPort,
                EnableSsl = _emailConfig.Value.EnableSsl,
                Credentials = new NetworkCredential(_emailConfig.Value.SmtpUsername, _emailConfig.Value.SmtpPassword)
            };

            var message = new MailMessage(
                new MailAddress(request.FromAddress.Address, request.FromAddress.Name),
                new MailAddress(request.ToAddress.Address, request.ToAddress.Name))
            {
                Subject = request.Subject,
                Body = request.Content
            };

            using(smtpClient)
            using (message)
            {
                await smtpClient.SendMailAsync(message);
            }

            return new SendEmailResponse
            {
                Result = true,
            };
        }
    }
}
