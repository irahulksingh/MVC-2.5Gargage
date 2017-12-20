using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_2._5Garage.DataLayer;
using MVC_2._5Garage.Models;
//using MVC_2._5Garage.Models;
using MVC_2._5Garage.Models.ViewModel;


namespace MVC_2._5Garage.Controllers
{
    public class VehiclesParkedsController : Controller
    {
        private DatabaseConnection db = new DatabaseConnection();



        // GET: VehiclesParkeds
                     public ActionResult Index(string SearchString, string SearchType)
        {
            var VehList = new List<string>();

            var VehQuery = from d in db.VehiclesParked select d.Vehicle.VehicleType;

            VehList.AddRange(VehQuery.Distinct());
            ViewBag.SearchType = new SelectList(VehList);

            var Vehicles = from v in db.VehiclesParked select v;

            if (!string.IsNullOrWhiteSpace(SearchString))
            {
                Vehicles = Vehicles.Where(s => s.RegNo.Contains(SearchString));
            }
            if (!string.IsNullOrWhiteSpace(SearchType))
            {
                //return View();
                Vehicles = Vehicles.Where(s => s.Vehicle.VehicleType == SearchType);
            }

            return View(Vehicles);


            ////ViewBag.VehicleId = new SelectList(db.VehiclesType, "Id", "VehicleType");


            ////var Vehicles = from v in db.VehiclesParked
            ////               select v;
            ////if (!string.IsNullOrWhiteSpace(SearchString))
            ////{
            ////    Vehicles = Vehicles.Where(s => s.RegNo.Contains(SearchString));
            ////}
            ////if (!string.IsNullOrWhiteSpace(SearchType))
            ////{
            ////    //return View();
            ////    Vehicles = Vehicles.Where(s => s.VehicleId.ToString().Contains(SearchType));
            ////}
            ////return View(Vehicles);
            // orginal code remove top and the string declaration to revert
            //var vehiclesParked = db.VehiclesParked.Include(v => v.Member).Include(v => v.Vehicle);
            //return View(vehiclesParked.ToList());
        }

        // GET: VehiclesParkeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehiclesParked vehiclesParked = db.VehiclesParked.Find(id);
            if (vehiclesParked == null)
            {
                return HttpNotFound();
            }
            return View(vehiclesParked);
        }

        // GET: VehiclesParkeds/Create
        public ActionResult Create()
        {
            ViewBag.MemberId = new SelectList(db.Members, "Id", "MemberName");
            ViewBag.VehicleId = new SelectList(db.VehiclesType, "Id", "VehicleType");
            return View();
        }

        // POST: VehiclesParkeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VehicleId,MemberId,RegNo,Model,Brand,NoOfWheels,CheckInTime,CheckOutTime")] VehiclesParked vehiclesParked)
        {
            if (ModelState.IsValid)
            {
                db.VehiclesParked.Add(vehiclesParked);
                db.Entry(vehiclesParked).Property(c => c.CheckInTime).CurrentValue = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MemberId = new SelectList(db.Members, "Id", "MemberName", vehiclesParked.MemberId);
            ViewBag.VehicleId = new SelectList(db.VehiclesType, "Id", "VehicleType", vehiclesParked.VehicleId);
            return View(vehiclesParked);
        }

        // GET: VehiclesParkeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehiclesParked vehiclesParked = db.VehiclesParked.Find(id);
            if (vehiclesParked == null)
            {
                return HttpNotFound();
            }
            ViewBag.MemberId = new SelectList(db.Members, "Id", "MemberName", vehiclesParked.MemberId);
            ViewBag.VehicleId = new SelectList(db.VehiclesType, "Id", "VehicleType", vehiclesParked.VehicleId);
            return View(vehiclesParked);
        }

        // POST: VehiclesParkeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,VehicleId,MemberId,RegNo,Model,Brand,NoOfWheels,CheckInTime,CheckOutTime")] VehiclesParked vehiclesParked)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehiclesParked).State = EntityState.Modified;
                db.Entry(vehiclesParked).Property(c => c.CheckInTime).CurrentValue = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MemberId = new SelectList(db.Members, "Id", "MemberName", vehiclesParked.MemberId);
            ViewBag.VehicleId = new SelectList(db.VehiclesType, "Id", "VehicleType", vehiclesParked.VehicleId);
            return View(vehiclesParked);
        }

        // GET: VehiclesParkeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehiclesParked vehiclesParked = db.VehiclesParked.Find(id);
            if (vehiclesParked == null)
            {
                return HttpNotFound();
            }
            return View(vehiclesParked);
        }

        // POST: VehiclesParkeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehiclesParked vehiclesParked = db.VehiclesParked.Find(id);
            var TotalTimeandPrice = new Receipt(vehiclesParked);
            db.VehiclesParked.Remove(vehiclesParked);
            db.SaveChanges();
            return View("DeleteConfirmed", TotalTimeandPrice);
        
            //return RedirectToAction("Index");
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
