using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    /// <summary>
    /// 作业对班级的公开表
    /// </summary>
    public class HomeworkOpen
    {
        public int HomeworkOpenId { get; set; }
        public virtual Homework Homework { get; set; }
        public virtual ClassInSchool Class { get; set; }
        public int Open { get; set; }


        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        public string Description { get; set; }

    }
}