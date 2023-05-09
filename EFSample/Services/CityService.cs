using EFSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Services
{
    public class CityService
    {
        public static List<City> GetAll()
        {
            AlohaECommerceContext context = new AlohaECommerceContext();
            List<City> list = context.Cities.ToList();

            return list;
        }
    }
}
