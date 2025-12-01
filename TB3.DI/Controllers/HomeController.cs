using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TB3.DI.Services;

namespace TB3.DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public HomeController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send")]
        public IActionResult SendNotification([FromBody] string message)
        {
            _notificationService.Send(message);
            return Ok(new
            {
                Message = "Notification sent successfully!"
            });
        }
    }
}
