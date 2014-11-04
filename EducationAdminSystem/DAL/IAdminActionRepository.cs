using EducationAdminSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationAdminSystem.DAL
{
    public interface IAdminActionRepository
    {
        IList<AdminAction> GetAllAdminActions();
        AdminAction FindById(int? id);
        void AddAction(AdminAction action);
        int UpdateAction(AdminAction adminAction);
    }
}
