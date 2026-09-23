using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Command.CarCommands
{
    public class UpdateBrandCommand
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
