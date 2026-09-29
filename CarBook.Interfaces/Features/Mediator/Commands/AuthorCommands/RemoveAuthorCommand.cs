using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveAuthorCommand(int id)
        {
            Id = id;
        }
    }
}
