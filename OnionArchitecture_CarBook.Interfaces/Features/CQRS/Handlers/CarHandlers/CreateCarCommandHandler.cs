using OnionArchitecture_CarBook.Application.Features.CQRS.Command.CarCommands;
using OnionArchitecture_CarBook.Application.Interfaces;
using OnionArchitecture_CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                Luggage = command.Luggage,
                Km = command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Transmission = command.Transmission,
                CoverImageUrl = command.CoverImageUrl,
                BrandID = command.BrandID,
                Fuel = command.Fuel
            });
        }
    }
}
