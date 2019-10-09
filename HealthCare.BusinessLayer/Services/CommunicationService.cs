namespace HealthCare.BusinessLayer.Services
{
    using System.Threading.Tasks;

    using Contracts.Models.Correspondence.Responses;
    using HealthCare.Interfaces;
    using Interfaces;
    using Utilities.Helpers.EmailSender.Extensions;
    using Utilities.Helpers.EmailSender.Models;

    public class CommunicationService : ICommunicationService
    {
        private readonly IEmailService _emailService;

        public CommunicationService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public async Task<SendEmailResponse> SendEmail<TViewModel>(EmailMessage message, TViewModel model)
            where TViewModel : class
        {
            await _emailService
                 .From(message.FromAddress)
                 .To(message.ToAddresses)
                 .Subject(message.Subject)
                 .UsingTemplate($"/Views/Emails/{typeof(TViewModel).Name}", model);

            await _emailService.Send();

            return new SendEmailResponse
            {
                Result = true,
            };
        }
    }
}
