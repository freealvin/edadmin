using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EducationAdminSystem.DAL;
using EducationAdminSystem.Models;

namespace EducationAdminSystem.Controllers
{
    public class SchoolYearsController : Controller
    {
        private EdAdminContext db = new EdAdminContext();

        // GET: SchoolYears
        public ActionResult Index()
        {
            return View(db.SchoolYears.ToList());
        }

        // GET: SchoolYears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolYear schoolYear = db.SchoolYears.Find(id);
            if (schoolYear == null)
            {
                return HttpNotFound();
            }
            return View(schoolYear);
        }

        // GET: SchoolYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolYears/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SchoolYearId,StartYear,EndYear,StartTime,EndTime,IsCurrent,Deleted,CreateUser,CreateTime,UpdateUser,UpdateTime,Description")] SchoolYear schoolYear)
        {
            if (ModelState.IsValid)
            {
                schoolYear.CreateTime = DateTime.Now;
                schoolYear.UpdateTime = DateTime.Now;
                schoolYear.CreateUser = "freealvin";
                db.SchoolYears.Add(schoolYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schoolYear);
        }

        // GET: SchoolYears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolYear schoolYear = db.SchoolYears.Find(id);
            if (schoolYear == null)
            {
                return HttpNotFound();
            }
            return View(schoolYear);
        }

        // POST: SchoolYears/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SchoolYearId,StartYear,EndYear,StartTime,EndTime,IsCurrent,Deleted,CreateUser,CreateTime,UpdateUser,UpdateTime,Description")] SchoolYear schoolYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(schoolYear);
        }

        // GET: SchoolYears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolYear schoolYear = db.SchoolYears.Find(id);
            if (schoolYear == null)
            {
                return HttpNotFound();
            }
            return View(schoolYear);
        }

        // POST: SchoolYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SchoolYear schoolYear = db.SchoolYears.Find(id);
            db.SchoolYears.Remove(schoolYear);
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
