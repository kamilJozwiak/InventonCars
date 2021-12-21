using AutoMapper;
using InventonCars.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventonCars.BLL
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarModel>()
                .ReverseMap();
        }
    }
}
