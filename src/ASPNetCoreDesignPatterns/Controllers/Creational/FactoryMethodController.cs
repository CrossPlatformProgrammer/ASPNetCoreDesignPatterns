using ASPNetCoreDesignPatterns.Patterns.Creational.FactoryMethod;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreDesignPatterns.Controllers.Creational
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactoryMethodController : ControllerBase
    {
        private readonly NotificationFactoryResolver _factoryResolver;

        public FactoryMethodController(NotificationFactoryResolver factoryResolver)
        {
            _factoryResolver = factoryResolver;
        }

        [HttpPost]
        public IActionResult SendNotification([FromBody] NotificationRequest request)
        {
            try
            {
                INotification notification = _factoryResolver.GetNotification(request.NotificationType);
                notification.Send(request.Recipient, request.Message);
                return Ok(new { Status = "Success", Message = "Notification sent successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Status = "Error", Message = ex.Message });
            }
        }
    }

    public class NotificationRequest
    {
        public NotificationType NotificationType { get; set; }
        public string? Recipient { get; set; }
        public string? Message { get; set; }
    }
    public enum NotificationType
    {
        Email,
        SMS,
        Push
    }
}
