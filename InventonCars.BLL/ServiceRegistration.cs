
using InventonCars.DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.BLL
{
    public static class ServiceRegistration
    {
        public static void AddBLL(this IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
            services.AddDAL();
        } 
    }
}
