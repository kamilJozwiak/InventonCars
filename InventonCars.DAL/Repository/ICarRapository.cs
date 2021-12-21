using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.DAL
{
    public interface ICarRapository
    {
        IEnumerable<Car> GetAll();
        Car GetById(Guid id);
        void Update(Car car);
        bool Delete(Guid id);
        void Insert(Car car);
    }
}
