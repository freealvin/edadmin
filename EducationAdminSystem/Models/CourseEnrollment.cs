using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class CourseEnrollment
    {
        public int CourseEnrollmentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

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