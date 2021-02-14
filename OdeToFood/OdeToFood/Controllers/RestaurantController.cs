using OdeFoodData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        private readonly IResturantData resturantData;
        public RestaurantController(IResturantData resturantData)
        {
            this.resturantData = resturantData;
        }
        public ActionResult Index()
        {
            var model = resturantData.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = resturantData.Get(id);
            if (model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }
    }
}