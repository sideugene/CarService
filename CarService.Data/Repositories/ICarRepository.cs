using CarService.Data.Entity;
using System.Collections.Generic;

namespace CarService.Data.Repositories
{
    public interface ICarRepository
    {
        void Create(Car car);
        Car Get(int id);
        List<Car> GetCars();
    }
}
