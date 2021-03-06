﻿using System;
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
            var Model = new TextsViewModel
            {
                AboutText = _database.Texts.Find("AboutText")
            };

            return View(Model);
        }

        public ActionResult Contact()
        {
            var Model = new TextsViewModel
            {
                ContactText = _database.Texts.Find("ContactText")
            };

            return View(Model);
        }

        public ActionResult PaymentShipping()
        {
            var Model = new PaymentViewModel
            {
                PaymentHeader = _database.Texts.Find("PaymentHeader"),
                PaymentBody = _database.Texts.Find("PaymentBody"),
                ShippingHeader = _database.Texts.Find("ShippingHeader"),
                ShippingBody = _database.Texts.Find("ShippingBody"),
            };

            return View(Model);
        }

    }
}