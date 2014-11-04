using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Courseware
    {
        public int CoursewareId { get; set; }

        [Required, ForeignKey("TeacherCourse")]
        public int TeacherCourseId { get; set; }
        public virtual TeacherCourse TeacherCourse { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }

        public int Size { get; set; }
        public string Extention { get; set; }
        public int DownloadCount { get; set; }
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