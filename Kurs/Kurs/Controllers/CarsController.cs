using Kurs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kurs.Controllers
{
    public class CarsController : Controller
    {

        private CarDBCtxt db = new CarDBCtxt();

        public ActionResult Index()
        {

            return View(db.Cars.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include ="Id,Brand,Model,Prize,Bought,Sold")] Car car)
        {
            if(ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }
       
    }
}