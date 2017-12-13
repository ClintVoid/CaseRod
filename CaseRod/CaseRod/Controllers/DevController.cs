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
    public class DevController : Controller
    {
        private ApplicationDbContext _database = new ApplicationDbContext();

        public ActionResult Index()
        {
            var Model = new DevViewModel
            {
                Blades = _database.Blades.ToList(),
                Handles = _database.Handles.ToList(),
                ReelSeats = _database.ReelSeats.ToList(),
                Texts = _database.Texts.ToList()
            };

            return View(Model);
        }

        #region Delete
        /*
        public ActionResult EditText(int id, int content)  
        {
            Text text = _database.Texts.Find(id);
           
        } */

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int id, int producttype)
        {
            switch (producttype)
            {
                case 1: 
                     Blade blade = _database.Blades.Find(id);
                     _database.Blades.Remove(blade);
                     _database.SaveChanges();                     
                break;
                case 2:
                    Handle handle = _database.Handles.Find(id);
                    _database.Handles.Remove(handle);
                    _database.SaveChanges();
                break;
                case 3:
                    ReelSeat reelseat = _database.ReelSeats.Find(id);
                    _database.ReelSeats.Remove(reelseat);
                    _database.SaveChanges();
                break;
                default: break;
            }

            return RedirectToAction("Index");
        }

        #endregion  

        #region Details
        public ActionResult DetailsBlade(int? id)
        {
            if (id == null)
            {
                return Index();
            }

            var Blade = _database.Blades.Find(id);
            
            if (Blade == null)
            { 
                return Index(); 
            }

            return View(Blade);
        }

        public ActionResult DetailsHandle(int? id)
        {
            if (id == null)
            {
                return Index();
            }

            var Handle = _database.Handles.Find(id);

            if (Handle == null)
            {
                return Index();
            }

            return View(Handle);
        }

        public ActionResult DetailsReelSeat(int? id)
        {
            if (id == null)
            {
                return Index();
            }

            var ReelSeat = _database.ReelSeats.Find(id);

            if (ReelSeat == null)
            {
                return Index();
            }

            return View(ReelSeat);
        }

        #endregion

        #region Create
        public ActionResult CreateBlade()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBlade([Bind(Include="ID,Name,PartNumber,Image,Weight,Price")] Blade blade)
        {
            if(ModelState.IsValid)
            {
                _database.Blades.Add(blade);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blade);
        }

        public ActionResult CreateHandle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateHandle([Bind(Include="ID,Name,PartNumber,Image,Weight,Price")] Handle handle)
        {
            if (ModelState.IsValid)
            {
                _database.Handles.Add(handle);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(handle);
        }

        public ActionResult CreateReelSeat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateReelSeat([Bind(Include = "ID,Name,PartNumber,Image,Weight,Price")] ReelSeat reelSeat)
        {
            if (ModelState.IsValid)
            {
                _database.ReelSeats.Add(reelSeat);
                _database.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reelSeat);
        }
        #endregion

        #region Edit
        public ActionResult EditText(string name)
        {
            if (name == null)
            {
                return RedirectToAction("Index");
            }
            Text text = _database.Texts.Find(name);
            if (text == null)
            {
                return RedirectToAction("Index");
            }
            return View(text);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditText([Bind(Include = "Name,Content")] Text texts) 
        {
            if (ModelState.IsValid)
            {
                _database.Entry(texts).State = EntityState.Modified;
                _database.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(texts);
        }
        #endregion
    }
}