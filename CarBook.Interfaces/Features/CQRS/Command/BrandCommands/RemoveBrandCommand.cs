using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Command.CarCommands
{
    public class RemoveBrandCommand
    {
        public int Id {  get; set; }

        public RemoveBrandCommand(int id)
        {
            this.Id = id;
        }
    }
}
