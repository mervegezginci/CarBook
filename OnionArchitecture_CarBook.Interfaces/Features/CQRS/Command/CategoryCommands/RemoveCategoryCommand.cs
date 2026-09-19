using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Command.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int Id {  get; set; }

        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
