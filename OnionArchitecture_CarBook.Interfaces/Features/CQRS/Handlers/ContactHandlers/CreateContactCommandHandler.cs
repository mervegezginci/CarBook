using OnionArchitecture_CarBook.Application.Features.CQRS.Command.ContactCommands;
using OnionArchitecture_CarBook.Application.Interfaces;
using OnionArchitecture_CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = command.Name,
                Email = command.Email,
                Subject = command.Subject,
                Message = command.Message,
                SendDate = command.SendDate
            });
        }
    }
}
