using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class RemoveFooterAddressCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveFooterAddressCommand(int id)
        {
            Id = id;
        }
    }
}
