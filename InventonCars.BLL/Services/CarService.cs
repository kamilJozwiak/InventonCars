using InventonCars.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.BLL
{
    public class CarService : ICarService
    {
        private readonly ICarRapository _carRepo;
        public CarService(ICarRapository carRapository)
        {
            _carRepo = carRapository;
        }
        public void Add(CarModel car)
        {
            if(car != null)
            {
                var entity = ObjectMapper.Mapper.Map<Car>(car);
                _carRepo.Insert(entity);
            }
        }

        public bool Delete(CarModel car)
        {
            if (car != null)
            {
                return _carRepo.Delete(car.IdCar);
            }
            return false;
        }

        public CarModel GetById(Guid id)
        {
            if (id != Guid.Empty)
            {
                var entity = _carRepo.GetById(id);
                var model = ObjectMapper.Mapper.Map<CarModel>(entity);
                return model;
            }
            return null;
        }

        public IEnumerable<CarModel> GetCars()
        {
            var entities = _carRepo.GetAll();
            var modelList = ObjectMapper.Mapper.Map<IEnumerable<CarModel>>(entities);
            return modelList;
        }

        public void SetDiscountForModel(string modelName, double discount)
        {
            foreach(var car in GetCars())
            {
                car.Discount = discount;
                var entity = ObjectMapper.Mapper.Map<Car>(car);
                _carRepo.Update(entity);
            }
        }

        public void Update(CarModel car)
        {
            var entity = ObjectMapper.Mapper.Map<Car>(car);
            _carRepo.Update(entity);
        }
    }
}
