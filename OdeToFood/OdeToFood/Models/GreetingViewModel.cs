using OdeFoodData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Resturant> Resturants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}