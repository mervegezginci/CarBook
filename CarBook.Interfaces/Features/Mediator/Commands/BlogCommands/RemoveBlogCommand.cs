using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands
{
    public class RemoveBlogCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveBlogCommand(int id)
        {
            Id = id;
        }
    }
}
