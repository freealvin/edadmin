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
    public class AdminstratorsController : Controller
    {
        private EdAdminContext db = new EdAdminContext();

        // GET: Adminstrators
        public ActionResult Index()
        {
            var adminstrators = db.Adminstrators.Include(a => a.AdminRole);
            return View(adminstrators.ToList());
        }

        // GET: Adminstrators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adminstrator adminstrator = db.Adminstrators.Find(id);
            if (adminstrator == null)
            {
                return HttpNotFound();
            }
            return View(adminstrator);
        }

        // GET: Adminstrators/Create
        public ActionResult Create()
        {
            ViewBag.RoleTypeId = new SelectList(db.AdminRoles, "AdminRoleId", "ActionList");
            return View();
        }

        // POST: Adminstrators/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdminstratorId,Account,NickName,Tel,Email,Actionlist,NavList,RoleTypeId,LastLogin,LastIp,CreateUser,CreateTime,UpdateUser,UpdateTime,Description")] Adminstrator adminstrator)
        {
            if (ModelState.IsValid)
            {
                db.Adminstrators.Add(adminstrator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RoleTypeId = new SelectList(db.AdminRoles, "AdminRoleId", "ActionList", adminstrator.RoleTypeId);
            return View(adminstrator);
        }

        // GET: Adminstrators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adminstrator adminstrator = db.Adminstrators.Find(id);
            if (adminstrator == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleTypeId = new SelectList(db.AdminRoles, "AdminRoleId", "ActionList", adminstrator.RoleTypeId);
            return View(adminstrator);
        }

        // POST: Adminstrators/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdminstratorId,Account,NickName,Tel,Email,Actionlist,NavList,RoleTypeId,LastLogin,LastIp,CreateUser,CreateTime,UpdateUser,UpdateTime,Description")] Adminstrator adminstrator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminstrator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RoleTypeId = new SelectList(db.AdminRoles, "AdminRoleId", "ActionList", adminstrator.RoleTypeId);
            return View(adminstrator);
        }

        // GET: Adminstrators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adminstrator adminstrator = db.Adminstrators.Find(id);
            if (adminstrator == null)
            {
                return HttpNotFound();
            }
            return View(adminstrator);
        }

        // POST: Adminstrators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adminstrator adminstrator = db.Adminstrators.Find(id);
            db.Adminstrators.Remove(adminstrator);
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
