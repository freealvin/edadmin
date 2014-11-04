using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentAccount { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string StudentName { get; set; }
        public int Gender { get; set; }
        public int Age { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(15)]
        public string HomeNumber { get; set; }
        [StringLength(15)]
        public string FatherTel { get; set; }
        [StringLength(15)]
        public string MotherTel { get; set; }

        [StringLength(20)]
        public string IdNumber { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        //public virtual ClassInSchool MyClass { get; set; }
    }
}