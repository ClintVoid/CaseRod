using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaseRod.ViewModels;
using CaseRod.Models;

namespace CaseRod.Controllers
{
    public class LucasController : Controller
    {

        private ApplicationDbContext _database = new ApplicationDbContext();

        // GET: Lucas
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
    }
}