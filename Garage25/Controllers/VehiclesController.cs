using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage25.Model;
using Garage25.Models;

namespace Garage25.Controllers
{
    public class VehiclesController : Controller
    {
        private GarageContext db = new GarageContext();

        // GET: Vehicles
        public ActionResult Index()
        {
        //public ActionResult Index(string searchString, string searchString2)
        //{
        //    var vehicles = from s in db.Vehicles
        //                   select s;

        //    if (!String.IsNullOrEmpty(searchString) && String.IsNullOrEmpty(searchString2))
        //    {
        //        vehicles = vehicles.Where(s => s.RegistrationNumber.Contains(searchString));
        //    }
        //    else if (!String.IsNullOrEmpty(searchString2) && String.IsNullOrEmpty(searchString))
        //    {
        //        vehicles = vehicles.Where(s => (s.VehicleType.Type.Contains(searchString2)));
        //    }
        //    else if (!String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(searchString2))
        //    {
        //        vehicles = vehicles.Where(s => s.RegistrationNumber.Contains(searchString)
        //            && (s.VehicleType.Type.Contains(searchString2)));
        //    }

            ViewBag.TypeId = new SelectList(db.VehicleTypes, "VehicleTypeId", "Type");            
            return View(db.Vehicles.ToList());
        }

        [HttpPost]
        public ActionResult Index(string searchString, string searchString2)
        {
            searchString2 = ViewBag.TypeId;
            var vehicles = from s in db.Vehicles
                           select s;

            if (!String.IsNullOrEmpty(searchString) && String.IsNullOrEmpty(searchString2))
            {
                vehicles = vehicles.Where(s => s.RegistrationNumber.Contains(searchString));
            }
            else if (!String.IsNullOrEmpty(searchString2) && String.IsNullOrEmpty(searchString))
            {
                vehicles = vehicles.Where(s => (s.VehicleType.Type.Contains(searchString2)));
            }
            else if (!String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(searchString2))
            {
                vehicles = vehicles.Where(s => s.RegistrationNumber.Contains(searchString)
                    && (s.VehicleType.Type.Contains(searchString2)));
            }

            return View(vehicles.ToList());
        }
        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var dbList = db.Members.ToList();
            foreach (var item in dbList)
            {
                list.Add(new SelectListItem
                {
                    Value = item.MemberId.ToString(),
                    Text = (item.Surname + " " + item.Lastname)
                });
            }
                //List<SelectListItem> list =
                //db.Members.Select(i => new SelectListItem{
                //    Text = i.MemberId.ToString(),
                //    Value = (i.Surname + " " + i.Lastname)
                //});

            ViewBag.Nameid = list;
            ViewBag.TypeId = new SelectList(db.VehicleTypes, "VehicleTypeId", "Type");
                
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleId,Color,Brand,Model,WheelCount,ParkTime,MemberId,VehicleTypeId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                var type = vehicle.VehicleType;
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleId,Color,Brand,Model,WheelCount,ParkTime,MemberId,VehicleTypeId")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
