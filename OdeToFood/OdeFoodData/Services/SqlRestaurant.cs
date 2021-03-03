using OdeFoodData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeFoodData.Services
{
    public class SqlRestaurant : IResturantData
    {
        private readonly OdeToFoodDbContext db;

        public SqlRestaurant(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public void Add(Resturant resturant)
        {
            db.Resturants.Add(resturant);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var resturant = db.Resturants.Find(id);
            db.Resturants.Remove(resturant);
            db.SaveChanges();
        }

        public Resturant Get(int id)
        {
            return db.Resturants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return from r in db.Resturants orderby r.Name select r;
        }

        public void Update(Resturant resturant)
        {
            var entry = db.Entry(resturant);
            entry.State =EntityState.Modified;
            db.SaveChanges();
        }
    }
}
