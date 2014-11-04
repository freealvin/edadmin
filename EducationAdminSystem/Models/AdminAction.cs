using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class AdminAction
    {
        public int AdminActionId { get; set; }

        public int ParentId{get; set;}
        public string Code { get; set; }
        public string Relevance { get; set; }
        public bool Enabled { get; set; }


        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }

    }
}