using OdeFoodData.Models;
using OdeFoodData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.API
{
    public class RestaurantsController : ApiController
    {
        private readonly IResturantData resturantData; 
        public RestaurantsController(IResturantData resturantData)
        {
            this.resturantData = resturantData;
        }
        public IEnumerable<Resturant> Get()
        {
            var model=resturantData.GetAll();
            return model;
        }
    }
}
