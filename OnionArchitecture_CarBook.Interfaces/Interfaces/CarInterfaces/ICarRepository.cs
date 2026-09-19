using OnionArchitecture_CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture_CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
        int GetCarCount();
    }
}
