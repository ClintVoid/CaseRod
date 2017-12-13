using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaseRod.ViewModels;
using CaseRod.Models;
using CaseRod.Controllers;

namespace CaseRod.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _database = new ApplicationDbContext();

       


        public ActionResult Index()
        {
            AuthorizeCookie();

            int defaultVal = 1;
            var CustomerCart = new Cart
            {
                Blade = _database.Blades.Find(defaultVal),
                Handle = _database.Handles.Find(defaultVal),
                ReelSeat = _database.ReelSeats.Find(defaultVal)
            };

            var Model = new BuildViewModel
            {
                Blades = _database.Blades.ToList(),
                Handles = _database.Handles.ToList(),
                ReelSeats = _database.ReelSeats.ToList(),
                Texts = _database.Texts.ToList(),
                Cart = CustomerCart
            };

            return View(Model);
        }

        public ActionResult Accessories()
        {
            var Model = new AccessoriesViewModel
            {
                Cases = _database.Accessories.Where(a => a.Type == Accessory.AccessoryType.Case).ToList(),
                Holders = _database.Accessories.Where(a => a.Type == Accessory.AccessoryType.Holder).ToList(),
                RodTubes = _database.Accessories.Where(a => a.Type == Accessory.AccessoryType.RodTube).ToList(),
                Texts = _database.Texts.ToList(),
            };

            return View(Model);
        }

        #region Helpers

        public void AuthorizeCookie()
        {
            if (Request.Cookies["Cart"] == null)
            {
                Response.Cookies["Cart"]["Blade"] = "1";
                Response.Cookies["Cart"]["Handle"] = "1";
                Response.Cookies["Cart"]["ReelSeat"] = "1";
                Response.Cookies["Cart"].Expires = DateTime.Now.AddDays(30);
            }
        }

        public void ChangeCookie(int blade, int handle, int reelSeat)
        {
            Response.Cookies["Cart"]["Blade"] = blade.ToString();
            Response.Cookies["Cart"]["Handle"] = handle.ToString();
            Response.Cookies["Cart"]["ReelSeat"] = reelSeat.ToString();
            Response.Cookies["Cart"].Expires = DateTime.Now.AddDays(30);
        }

        #endregion  
    }
}