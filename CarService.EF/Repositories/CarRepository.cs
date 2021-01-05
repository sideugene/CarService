using CarService.Data.Entity;
using CarService.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CarService.EF.Repositories
{
    public class CarRepository : ICarRepository
    {
        private ServiceContext context;

        public CarRepository(ServiceContext context)
        {
            this.context = context;
        }

        public void Create(Car car)
        {
                context.Cars.Add(car);
                context.SaveChanges();
        }

        public Car Get(int id)
        {
                return context.Cars.FirstOrDefault(c => c.Id == id);
        }

        public List<Car> GetCars()
        {
                return context.Cars.ToList();
        }
    }
}
