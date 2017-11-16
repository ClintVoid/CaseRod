using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaseRod.Models;
using CaseRod.ViewModels;

namespace CaseRod.Controllers
{
    public class DevController : Controller
    {
        private ApplicationDbContext _database = new ApplicationDbContext();

        public ActionResult Index()
        {
            var Model = new DevViewModel
            {
                Blades = _database.Blades.ToList(),
                Handles = _database.Handles.ToList(),
                ReelSeats = _database.ReelSeats.ToList()
            };

            return View(Model);
        }

        public ActionResult CreateBlade()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBlade([Bind(Include="BladeID,Name,PartNumber,Image,Weight,Price")] Blade blade)
        {
            if(ModelState.IsValid)
            {
                _database.Blades.Add(blade);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blade);
        }
    }
}