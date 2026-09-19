using Microsoft.EntityFrameworkCore;
using OnionArchitecture_CarBook.Application.Interfaces.CarInterfaces;
using OnionArchitecture_CarBook.Domain.Entities;
using OnionArchitecture_CarBook.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;
        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }
        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarId).Take(5).ToList();
            return values;
        }
    }
}
