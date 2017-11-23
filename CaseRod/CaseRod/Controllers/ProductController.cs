using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaseRod.ViewModels;
using CaseRod.Models;  

namespace CaseRod.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _database = new ApplicationDbContext();

        public ActionResult Index()
        {
            var Model = new BuildViewModel
            {
                Blades = _database.Blades.ToList(),
                Handles = _database.Handles.ToList(),
                ReelSeats = _database.ReelSeats.ToList(),

            };

            if (Session["Product"] == null)
            {
                Model.Product = new Product { Price = 0, Weight = 0, ChosenBlade = _database.Blades.Find(2) };

                return View(Model);
            }

            Model.Product = Session["Product"] as Product;

            return View(Model);
        }

        public ActionResult ChooseBlade(int? id)
        {
            var Product = Session["Product"] as Product;

            Product.ChosenBlade = _database.Blades.Find(id);

            Session["Product"] = Product;

            return RedirectToAction("Index");
        }

        public ActionResult ChooseHandle(int? id)
        {
            var Product = Session["Product"] as Product;

            Product.ChosenHandle = _database.Handles.Find(id);

            Session["Product"] = Product;

            return RedirectToAction("Index");
        }
    }
}