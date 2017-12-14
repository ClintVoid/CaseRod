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
            HttpCookie Cookie = AuthorizeCookie();

            var CustomerCart = new Cart
            {
                Blade = _database.Blades.Find(StringToInt(Cookie.Values["Blade"])),
                Handle = _database.Handles.Find(StringToInt(Cookie.Values["Handle"])),
                ReelSeat = _database.ReelSeats.Find(StringToInt(Cookie.Values["ReelSeat"]))
            };

            var Model = new BuildViewModel
            {
                Blades = _database.Blades.ToList(),
                Handles = _database.Handles.ToList(),
                ReelSeats = _database.ReelSeats.ToList(),
                InfoHeader = _database.Texts.Find("InfoHeader"),
                InfoBladesHeader = _database.Texts.Find("InfoBladesHeader"),
                InfoHandlesHeader = _database.Texts.Find("InfoHandlesHeader"),
                InfoReelsHeader = _database.Texts.Find("InfoReelsHeader"),
                InfoBody = _database.Texts.Find("InfoBody"),
                InfoBladesBody = _database.Texts.Find("InfoBladesBody"),
                InfoHandlesBody = _database.Texts.Find("InfoHandlesBody"),
                InfoReelsBody = _database.Texts.Find("InfoReelsBody"),


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
                AccessoriesHeader = _database.Texts.Find("AccessoriesHeader"),
                AccessoriesBody = _database.Texts.Find("AccessoriesBody")
            };

            return View(Model);
        }

        #region Helpers

        public HttpCookie AuthorizeCookie()
        {
            HttpCookie Cookie = Request.Cookies["Cart"];

            if (Cookie == null || String.IsNullOrEmpty(Cookie.Value))
            {
                Cookie = new HttpCookie("Cart");

                Cookie.Values["Blade"] = "0";
                Cookie.Values["Handle"] = "0";
                Cookie.Values["ReelSeat"] = "0";
                Cookie.Expires = DateTime.Now.AddDays(90);

                Response.Cookies.Add(Cookie);
            }

            return Cookie; 
        }

        public void ChangeCookie(int blade, int handle, int reelSeat)
        {
            Response.Cookies["Cart"]["Blade"] = blade.ToString();
            Response.Cookies["Cart"]["Handle"] = handle.ToString();
            Response.Cookies["Cart"]["ReelSeat"] = reelSeat.ToString();
            Response.Cookies["Cart"].Expires = DateTime.Now.AddDays(30);
        }

        public int StringToInt(string value)
        {
            return Convert.ToInt32(value);
        }

        #endregion  
    }
}