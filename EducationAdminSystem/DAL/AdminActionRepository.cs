using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationAdminSystem.DAL
{
    public class AdminActionRepository : IAdminActionRepository
    {
        private EdAdminContext _db = new EdAdminContext();
        public IList<Models.AdminAction> GetAllAdminActions()
        {
            return (from action in _db.AdminActions orderby action.AdminActionId ascending select action).Take(20).ToList();
        }

        public Models.AdminAction FindById(int? id)
        {
            return _db.AdminActions.Find(id);
        }

        public void AddAction(Models.AdminAction action)
        {
            _db.AdminActions.Add(action);
            _db.SaveChanges();
        }




        public int UpdateAction(Models.AdminAction adminAction)
        {

            var statEntry = _db.Entry(adminAction);
            statEntry.State = System.Data.Entity.EntityState.Unchanged;

            statEntry.Property(e => e.Enabled).IsModified = true;
            statEntry.Property(e => e.Description).IsModified = true;
            statEntry.Property(e => e.ParentId).IsModified = true;
            statEntry.Property(e => e.Code).IsModified = true;
            return _db.SaveChanges();
        }
    }
}