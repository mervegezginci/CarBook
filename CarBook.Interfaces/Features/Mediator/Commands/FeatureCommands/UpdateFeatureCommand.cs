using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand : IRequest
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
