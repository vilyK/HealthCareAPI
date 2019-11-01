namespace HealthCare.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using BusinessLayer.Interfaces;
    
    [Route("notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
    }
}