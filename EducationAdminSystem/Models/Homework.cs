using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }
        public virtual TeacherCourse TeacherCourse { get; set; }
        public int IsExpired { get; set; }
        public int Deleted { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Required]
        [StringLength(200)]
        public string HomeworkTitle { get; set; }
        [StringLength(1000)]
        public string HomeworkDescription { get; set; }

        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }

    }
}