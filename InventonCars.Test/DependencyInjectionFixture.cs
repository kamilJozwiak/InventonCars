using InventonCars.BLL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.Test
{
    public class DependencyInjectionFixture
    {
        public ServiceProvider ServiceProvider { get; }

        public DependencyInjectionFixture()
        {
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBLL();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
