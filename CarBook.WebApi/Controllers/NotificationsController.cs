using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.WebApi.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IRepository<Notification> _repository;
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationsController(
            IRepository<Notification> repository,
            IHubContext<NotificationHub> hubContext)
        {
            _repository = repository;
            _hubContext = hubContext;
        }


        // Tüm bildirimleri getir
        [HttpGet]
        public async Task<IActionResult> NotificationList()
        {
            var values = await _repository.GetAllAsync();

            var orderedValues = values
                .OrderByDescending(x => x.CreatedDate)
                .ToList();

            return Ok(orderedValues);
        }


        // Okunmamış bildirim sayısı
        [HttpGet("UnreadCount")]
        public async Task<IActionResult> UnreadCount()
        {
            var values = await _repository.GetAllAsync();

            var count = values.Count(x => x.IsRead == false);

            return Ok(count);
        }


        // SignalR test işlemi
        [HttpGet("SendNotification")]
        public async Task<IActionResult> SendNotification()
        {
            await _hubContext.Clients.All.SendAsync(
                "ReceiveNotification",
                "Test Bildirimi",
                "SignalR bağlantısı başarıyla çalışıyor."
            );

            return Ok("Bildirim gönderildi.");
        }
    }
}