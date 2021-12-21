using InventonCars.BLL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Xunit;

namespace InventonCars.Test
{
    public class CarServiceTest : IClassFixture<DependencyInjectionFixture>
    {
        private readonly ICarService _sut;
        public CarServiceTest(DependencyInjectionFixture fixture)
        {
            using var scope = fixture.ServiceProvider.CreateScope();
            _sut = scope.ServiceProvider.GetService<ICarService>();
        }
        [Fact]
        public void GetCars_ShouldWork()
        {
            var cars = _sut.GetCars();
            Assert.True(cars.Any());
        }

        [Fact]
        public void Add()
        {
            var car = new CarModel
            {
                BrandName = "Ford",
                ModelName = "Fiesta",
                IdCar = Guid.NewGuid(),
                Price = 10200
            };
            _sut.Add(car);

            var car2 = _sut.GetById(car.IdCar);

            Assert.Equal(car.IdCar, car2.IdCar);
        }
        [Fact]
        public void SetDiscountForModel()
        {
            var modelName = "Focus";
            var focus = _sut.GetCars().FirstOrDefault(c => c.ModelName == modelName);
            _sut.SetDiscountForModel(modelName, 10);

            var focusAfterDiscount = _sut.GetCars().FirstOrDefault(c => c.ModelName == modelName);

            var firstPrice = focus.Price * 0.9;
            var secondPrice = focusAfterDiscount.PriceAfterDiscount;

            Assert.Equal(firstPrice, secondPrice);
        }
    }
}
