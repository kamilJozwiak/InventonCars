using Microsoft.Extensions.DependencyInjection;

namespace InventonCars.DAL
{
    public static class ServiceRegistration
    {
        public static void AddDAL(this IServiceCollection services)
        {
            services.AddTransient<ICarRapository, CarRepository>();
        }
    }
}