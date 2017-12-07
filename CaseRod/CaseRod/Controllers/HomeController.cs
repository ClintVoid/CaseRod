using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaseRod.Models;
using CaseRod.ViewModels;
using System.Data.Entity;
using System.Net;

namespace CaseRod.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _database = new ApplicationDbContext();

        public ActionResult Index()
        {
               return View();
        }

        public ActionResult About()
        {
            var Model = new HomeViewModel
            {
                Texts = _database.Texts.ToList()
            };

            return View(Model);
        }

        public ActionResult Contact()
        {
            var Model = new HomeViewModel
            {
                Texts = _database.Texts.ToList()
            };

            return View(Model);
        }
    }
}