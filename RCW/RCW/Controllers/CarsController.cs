﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RCW.Models;

namespace RCW.Controllers
{
    public class CarsController : Controller
    {
        private CarDBContext db = new CarDBContext();

        //
        // GET: /Cars/

        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        //
        // GET: /Cars/Details/5

        public ActionResult Details(int id = 0)
        {
            Car car = db.Movies.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        //
        // GET: /Cars/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cars/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        //
        // GET: /Cars/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Car car = db.Movies.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        //
        // POST: /Cars/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        //
        // GET: /Cars/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Car car = db.Movies.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        //
        // POST: /Cars/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Movies.Find(id);
            db.Movies.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}