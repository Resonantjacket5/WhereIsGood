﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WhereIsGood.DAL;
using WhereIsGood.Models;

namespace WhereIsGood.Controllers
{
    public class PreferencesController : Controller
    {
        private FoodContext db = new FoodContext();

        // GET: Preferences
        public ActionResult Index()
        {
            return View(db.Preferences.ToList());
        }

        // GET: Preferences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Preference preference = db.Preferences.Find(id);
            if (preference == null)
            {
                return HttpNotFound();
            }
            return View(preference);
        }

        // GET: Preferences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Preferences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PreferenceID,Distance,CourseID,StudentID,Grade")] Preference preference)
        {
            if (ModelState.IsValid)
            {
                db.Preferences.Add(preference);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(preference);
        }

        // GET: Preferences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Preference preference = db.Preferences.Find(id);
            if (preference == null)
            {
                return HttpNotFound();
            }
            return View(preference);
        }

        // POST: Preferences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PreferenceID,Distance,CourseID,StudentID,Grade")] Preference preference)
        {
            if (ModelState.IsValid)
            {
                db.Entry(preference).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(preference);
        }

        // GET: Preferences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Preference preference = db.Preferences.Find(id);
            if (preference == null)
            {
                return HttpNotFound();
            }
            return View(preference);
        }

        // POST: Preferences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Preference preference = db.Preferences.Find(id);
            db.Preferences.Remove(preference);
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
