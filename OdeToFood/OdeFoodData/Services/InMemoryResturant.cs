using OdeFoodData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(Resturant resturant)
        {
            resturants.Add(resturant);
            resturant.Id = resturants.Max(r=>r.Id)+1;
        }

        public Resturant Get(int id)
        {
            return resturants.FirstOrDefault(r=>r.Id==id);
        }

        public List<Resturant> GetAll()
        {
            return resturants;
        }

        public void Update(Resturant resturant)
        {
            var existing = Get(resturant.Id);
            if (existing != null)
            {
                existing.Name = resturant.Name;
                existing.Cuisine = resturant.Cuisine;
            }
        }
    }
}
