using OdeFoodData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeFoodData.Services
{
    public class OdeToFoodDbContext:DbContext
    {
        public DbSet<Resturant> Resturants { get; set; }
    }
}
