using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    //班级
    public class ClassInSchool
    {
        public int ClassInSchoolId { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }

        //班级是哪一个年级的
        public virtual Grade Grade { get; set; }
        //哪个学年的
        public virtual SchoolYear SchoolYear { get; set; }
        /// <summary>
        /// 是否标志删除
        /// </summary>
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