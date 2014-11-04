using EducationAdminSystem.DAL;
using EducationAdminSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EducationAdminSystem.Controllers
{
    public class AdminActionController : Controller
    {
        private IAdminActionRepository _respository;
        public AdminActionController()
        {
            _respository = new AdminActionRepository();
        }

        public AdminActionController(IAdminActionRepository _respository)
        {
            this._respository = _respository;
        }
        // GET: AdminAction
        public ActionResult Index()
        {
            var actions = _respository.GetAllAdminActions();
            foreach(var action in actions)
            {
                action.Code = Resources.Global.ResourceManager.GetString(action.Code);
            }
            return View(actions);
        }

        public ActionResult Create()
        {

            ViewBag.ParentId = new SelectList(_respository.GetAllAdminActions(), "AdminActionId", "Code");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdminActionId,Code, ParentId,CreateUser,CreateTime,UpdateUser,UpdateTime,Description")] AdminAction adminAction)
        {
            if (ModelState.IsValid)
            {
                adminAction.Enabled = false;
                adminAction.ParentId = 0;
                adminAction.Relevance = "";
                _respository.AddAction(adminAction);

                return RedirectToAction("Index");
            }
            //new SelectList(db.AdminRoles, "AdminRoleId", "ActionList", adminstrator.RoleTypeId);
            ViewBag.ParentId = new SelectList(_respository.GetAllAdminActions(), "AdminActionId", "Code", adminAction.ParentId);
            return View(adminAction);
        }

         public ActionResult Edit(int ?id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.ParentId = new SelectList(_respository.GetAllAdminActions(), "AdminActionId", "Code");
            AdminAction action = _respository.FindById(id);
            return View(action);
        }

         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Edit([Bind(Include = "AdminActionId,Code, Enabled, ParentId, Description")] AdminAction adminAction)
         {
             if (ModelState.IsValid)
             {
                 _respository.UpdateAction(adminAction);
                 return RedirectToAction("Index");
             }
             //new SelectList(db.AdminRoles, "AdminRoleId", "ActionList", adminstrator.RoleTypeId);
             ViewBag.ParentId = new SelectList(_respository.GetAllAdminActions(), "AdminActionId", "Code", adminAction.ParentId);
             return View(adminAction);
         }
    }
}