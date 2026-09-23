using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Command.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}
