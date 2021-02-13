using OdeFoodData.Models;
using System;
using System.Collections.Generic;

namespace OdeFoodData.Services
{
    public class InMemoryResturant : IResturantData
    {
        List<Resturant> resturants;
        public InMemoryResturant()
        {
            resturants = new List<Resturant>()
            {
                new Resturant(){Id=1,Name="Scoot's Pizza",Cuisine=CuisineType.chinese },
                new Resturant(){Id=2,Name="Mango Grave ",Cuisine=CuisineType.French },
                new Resturant(){Id=3,Name="Terigulous ",Cuisine=CuisineType.Italian },
                new Resturant(){Id=4,Name="Nala royal ",Cuisine=CuisineType.Indian }
            };
        }
        public List<Resturant> GetAll()
        {
            return resturants;
        }
    }
}
