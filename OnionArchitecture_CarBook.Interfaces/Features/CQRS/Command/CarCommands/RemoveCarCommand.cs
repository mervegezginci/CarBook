using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Command.CarCommands
{
    public class RemoveCarCommand
    {
        public int Id { get; set; }

        public RemoveCarCommand(int id)
        {
            this.Id = id;
        }
    }
}
