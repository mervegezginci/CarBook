using OnionArchitecture_CarBook.Application.Features.CQRS.Command.ContactCommands;
using OnionArchitecture_CarBook.Application.Interfaces;
using OnionArchitecture_CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ContactID);
            values.Name = command.Name;
            values.Email = command.Email;
            values.Subject = command.Subject;
            values.Message = command.Message;
            values.SendDate = command.SendDate;
            await _repository.UpdateAsync(values);
        }
    }
}
