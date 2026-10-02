using CarBook.Application.Features.CQRS.Command.ContactCommands;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.WebApi.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly CreateContactCommandHandler _createContactCommandHandler;
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;
        private readonly RemoveContactCommandHandler _removeContactCommandHandler;

        private readonly IRepository<Notification> _notificationRepository;
        private readonly IHubContext<NotificationHub> _hubContext;


        public ContactsController(
            CreateContactCommandHandler createContactCommandHandler,
            GetContactByIdQueryHandler getContactByIdQueryHandler,
            GetContactQueryHandler getContactQueryHandler,
            UpdateContactCommandHandler updateContactCommandHandler,
            RemoveContactCommandHandler removeContactCommandHandler,
            IRepository<Notification> notificationRepository,
            IHubContext<NotificationHub> hubContext)
        {
            _createContactCommandHandler = createContactCommandHandler;
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _getContactQueryHandler = getContactQueryHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
            _removeContactCommandHandler = removeContactCommandHandler;

            _notificationRepository = notificationRepository;
            _hubContext = hubContext;
        }


        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _getContactQueryHandler.Handle();

            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _getContactByIdQueryHandler.Handle(
                new GetContactByIdQuery(id));

            return Ok(value);
        }


        [HttpPost]
        public async Task<IActionResult> CreateContact(
            CreateContactCommand command)
        {
            // 1. Mesajı veritabanına kaydet
            await _createContactCommandHandler.Handle(command);


            // 2. Bildirimi oluştur
            var notification = new Notification
            {
                Type = "Message",
                Title = "Yeni Mesaj",
                Description = $"{command.Name} yeni bir mesaj gönderdi.",
                CreatedDate = DateTime.Now,
                IsRead = false
            };


            // 3. Bildirimi veritabanına kaydet
            await _notificationRepository.CreateAsync(notification);


            // 4. SignalR ile admin paneline anlık gönder
            await _hubContext.Clients.All.SendAsync(
                "ReceiveNotification",
                notification.Title,
                notification.Description
            );


            return Ok("Mesaj başarıyla gönderildi");
        }


        [HttpDelete]
        public async Task<IActionResult> RemoveContact(int id)
        {
            await _removeContactCommandHandler.Handle(
                new RemoveContactCommand(id));

            return Ok("İletişim Bilgisi Silindi");
        }


        [HttpPut]
        public async Task<IActionResult> UpdateContact(
            UpdateContactCommand command)
        {
            await _updateContactCommandHandler.Handle(command);

            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}