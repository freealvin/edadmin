using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required]
        [StringLength(50)]
        public string TeacherAccout { get; set; }
        [StringLength(50)]
        public string TeacherName { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string ZhiWu { get; set; }
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