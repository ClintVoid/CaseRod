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
                Texts = _database.Texts.ToList()
            };

            if (Session["Product"] == null)
            {
                var Product = new Product { Price = 0, Weight = 0 };

                Session["Product"] = Product;

                Model.Product = Session["Product"] as Product;

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

            SummarizeProductInfo();

            return RedirectToAction("Index");
        }

        public ActionResult ChooseHandle(int? id)
        {
            var Product = Session["Product"] as Product;

            Product.ChosenHandle = _database.Handles.Find(id);

            Session["Product"] = Product;

            SummarizeProductInfo();

            return RedirectToAction("Index");
        }

        public ActionResult ChooseReelSeat(int? id)
        {
            var Product = Session["Product"] as Product;

            Product.ChosenReelSeat = _database.ReelSeats.Find(id);

            Session["Product"] = Product;

            SummarizeProductInfo();

            return RedirectToAction("Index");
        }

        public ActionResult ChooseCase(int? id) {
            return RedirectToAction("Index");
        }

        public ActionResult ChooseHolder(int? id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult ChooseRodTube(int? id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Accessories()
        {

            //User.UserActivities.Where(UserActivity => UserActivity.Activity == activity

            var Model = new AccessoriesViewModel
            {
                Cases = _database.Accessories.Where(a => a.Type == Accessory.AccessoryType.Case).ToList(),
                Holders = _database.Accessories.Where(a => a.Type == Accessory.AccessoryType.Holder).ToList(),
                RodTubes = _database.Accessories.Where(a => a.Type == Accessory.AccessoryType.RodTube).ToList(),
                Product = Session["Product"] as Product
            };

            return View(Model);
        }

        public void SummarizeProductInfo()
        {
            var Product = Session["Product"] as Product;

            Product.Price = 0;
            Product.Weight = 0;

            if (Product.ChosenBlade != null)
            {
                Product.Price += Product.ChosenBlade.Price;
                Product.Weight += Product.ChosenBlade.Weight;
            }

            if (Product.ChosenHandle != null)
            {
                Product.Price += Product.ChosenHandle.Price;
                Product.Weight += Product.ChosenHandle.Weight;
            }

            if (Product.ChosenReelSeat != null)
            {
                Product.Price += Product.ChosenReelSeat.Price;
                Product.Weight += Product.ChosenReelSeat.Weight;
            }

            Session["Product"] = Product;
        }

        
    }
}