using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class ActionViewModel
    {
        public int ActionId { get; set; }
        public string Code { get; set; }
        IList<AdminAction> ChildActions { get; set; }
        public string ShowValue { get; set; }
    }
}