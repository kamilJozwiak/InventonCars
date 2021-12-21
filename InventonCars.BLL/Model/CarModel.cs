using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.BLL
{
    public class CarModel
    {
        private double _discount;
        public Guid IdCar { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public double Price { get; set; }
        public double PriceAfterDiscount
        {
            get
            {
                return Price * (100d - Discount) / 100;
            }
        }
        public double Discount
        {
            get
            {
                if (_discount > 100) return 100;
                if (_discount < 0) return 0;
                return _discount;
            }
            set { _discount = value; }
        }
    }
}
