using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [StringLength(50)]
        public string CourseName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IsClosed { get; set; }
        public int Deleted { get; set; }

        //选修，必修，部分班级必修,是不是限制由哪个年级上
        public int CourseType { get; set; }
        //如果限制由哪几个年纪上，用此字段存储存储格式 gradeId1|gradeId2
        public string OnlyGrades { get; set; }
        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public virtual SchoolTerm SchoolTerm { get; set; }

    }
}