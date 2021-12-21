
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.BLL
{
    public interface ICarService
    {
        IEnumerable<CarModel> GetCars();
        CarModel GetById(Guid id);
        void Add(CarModel car);
        void Update(CarModel car);
        bool Delete(CarModel car);
        void SetDiscountForModel(string modelName, double discount);
    }
}
