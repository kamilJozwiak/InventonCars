using System;

namespace InventonCars.DAL
{
    public class Car
    {
        public Guid IdCar { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
    }
}