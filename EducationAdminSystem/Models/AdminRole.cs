using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class AdminRole
    {
        public int AdminRoleId { get; set; }
        public string ActionList { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        public DateTime LastLogin { get; set; }
        [StringLength(20)]
        public string LastIp { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }
    }
}