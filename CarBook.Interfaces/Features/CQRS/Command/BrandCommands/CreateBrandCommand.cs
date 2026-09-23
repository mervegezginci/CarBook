using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Command.CarCommands
{
    public class CreateBrandCommand
    {
        public string Name { get; set; }
    }
}
