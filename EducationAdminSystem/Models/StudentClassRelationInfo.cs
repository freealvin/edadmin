using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class StudentClassRelationInfo
    {
        public int StudentClassRelationInfoId { get; set; }

        //学期
        public virtual SchoolTerm SchooTerm { get; set; }
        public virtual Student Student { get; set; }
        public virtual ClassInSchool Class { get; set; }

        //学生升级或者换班后设置为1，并建立新的关系
        public int IsExpired { get; set; }
        public int Deleted { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }
    }
}