using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeMAnagementSystem.Context;
using EmployeeMAnagementSystem.Models;

namespace EmployeeMAnagementSystem.Controllers
{
    public class employeeModelsController : Controller
    {
        private employeeContext db = new employeeContext();

        // GET: employeeModels
        public ActionResult Index()
        {
            return View(db.employees.ToList());
        }

        // GET: employeeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeModel employeeModel = db.employees.Find(id);
            if (employeeModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeModel);
        }

        // GET: employeeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: employeeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "employeeId,name,place,description,email")] employeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                db.employees.Add(employeeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeModel);
        }

        // GET: employeeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeModel employeeModel = db.employees.Find(id);
            if (employeeModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeModel);
        }

        // POST: employeeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "employeeId,name,place,description,email")] employeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeModel);
        }

        // GET: employeeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            employeeModel employeeModel = db.employees.Find(id);
            if (employeeModel == null)
            {
                return HttpNotFound();
            }
            return View(employeeModel);
        }

        // POST: employeeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            employeeModel employeeModel = db.employees.Find(id);
            db.employees.Remove(employeeModel);
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
