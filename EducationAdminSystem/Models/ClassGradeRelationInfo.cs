using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    /// <summary>
    /// 为了防止学生升级，创建了班级和年纪的关系表，班级升级后，之前的项中的IsExpired置为1
    /// </summary>
    public class ClassGradeRelationInfo
    {
        public int ClassGradeRelationInfoId { get; set; }
        public virtual ClassInSchool Class { get; set; }
        public virtual Grade Grade { get; set; }

        //是不是过期了，默认为0：未过期
        public int IsExpired { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }
    }
}