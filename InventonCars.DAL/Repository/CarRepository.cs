using System;
using System.Collections.Generic;
using System.Linq;

namespace InventonCars.DAL
{
    public class CarRepository : ICarRapository
    {
        private static readonly ISet<Car> _cars = new HashSet<Car>()
        {
            new Car{ IdCar = Guid.NewGuid(), BrandName = "Ford", ModelName = "Focus", Price = 50000d },
            new Car{ IdCar = Guid.NewGuid(), BrandName = "Opel", ModelName = "Corsa", Price = 19000d },
            new Car{ IdCar = Guid.NewGuid(), BrandName = "Volvo", ModelName = "XC60", Price = 84999d }
        };

        public bool Delete(Guid id)
        {
            var car = _cars.FirstOrDefault(c => c.IdCar == id);
            return _cars.Remove(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Guid id)
        {
            return _cars.FirstOrDefault(c => c.IdCar == id);
        }

        public void Insert(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.FirstOrDefault(c => c.IdCar == car.IdCar);
            if (carToUpdate != null)
            {
                carToUpdate.BrandName = car.BrandName;
                carToUpdate.ModelName = car.ModelName;
                carToUpdate.Price = car.Price;
                carToUpdate.Discount = car.Discount;
            }
        }
    }
}