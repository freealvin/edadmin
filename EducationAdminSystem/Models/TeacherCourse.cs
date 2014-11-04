using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    /// <summary>
    /// 教师课程关系类
    /// </summary>
    public class TeacherCourse
    {
        public int TeacherCourseId { get; set; }

        //教师
        public virtual Teacher Teacher { get; set; }
        //课程
        public virtual Course Course { get; set; }

        public int Deleted { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }

        //学期结束，自动设为过期
        public int IsExpired { get; set; }
        //哪个学期任教的
        public virtual SchoolTerm SchoolTerm { get; set; }
    }
}