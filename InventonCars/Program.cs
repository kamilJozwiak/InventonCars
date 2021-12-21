using InventonCars.BLL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace InventonCars
{
    class Program
    {
        static void Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();
            var carService = GetCarService(host.Services);

            var cars = carService.GetCars();
        }
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddBLL());
        }

        private static ICarService GetCarService(IServiceProvider services)
        {
            using var serviceScope = services.CreateScope();
            var provider = serviceScope.ServiceProvider;

            var carService = provider.GetRequiredService<ICarService>();
            return carService;
        }
    }
}
