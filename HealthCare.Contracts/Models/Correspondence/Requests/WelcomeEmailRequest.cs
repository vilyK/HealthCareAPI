namespace HealthCare.Contracts.Models.Correspondence.Requests
{
    using RazorProject.ViewModels;
    using Utilities.Helpers.EmailSender.Models;

    public class WelcomeEmailRequest
    {
        public EmailMessage Message { get; set; }

        public WelcomeViewModel WelcomeViewModel { get; set; }
    }
}
