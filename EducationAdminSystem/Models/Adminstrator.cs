using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Adminstrator
    {
        public int AdminstratorId { get; set; }
        [Required]
        [StringLength(50)]
        public string Account { get; set; }
        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(15)]
        public string Tel { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public string Actionlist { get; set; }
        public string NavList { get; set; }

        [ForeignKey("AdminRole")]
        public int RoleTypeId { get; set; }
        public virtual AdminRole AdminRole { get; set; }

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