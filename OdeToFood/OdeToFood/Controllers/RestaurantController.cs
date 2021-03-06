using OdeFoodData.Models;
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
        [HttpGet]
        public ActionResult Index()
        {
            var model = resturantData.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = resturantData.Get(id);
            if (model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Resturant resturant )
        {
            if (ModelState.IsValid)
            {
                resturantData.Add(resturant);
                return RedirectToAction("Details",new { id= resturant.Id});
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = resturantData.Get(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Resturant resturant)
        {
            if (ModelState.IsValid)
            {
                resturantData.Update(resturant);
                TempData["Message"]= "You have saved restaurant!";
                return RedirectToAction("Details",new { id=resturant.Id});
            }
            return View(resturant);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = resturantData.Get(id);
            if (model==null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,FormCollection form)
        {
            resturantData.Delete(id);
            return RedirectToAction("Index");
        }
    }
}