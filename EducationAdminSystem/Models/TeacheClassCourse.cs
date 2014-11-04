using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class TeacheClassCourse
    {
        public int TeacheClassCourseId { get; set; }
        public virtual TeacherCourse TeacherCourseRelation { get; set; }
        public virtual ClassInSchool Class { get; set; }

        public int IsExpired { get; set; }
        public int Deleted { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }
    }
}