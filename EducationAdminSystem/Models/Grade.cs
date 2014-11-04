using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        [Required, StringLength(50)]
        public string GradeName { get; set; }

        /// <summary>
        /// 年纪的升级顺序，默认为1，此值越大年级越大，年级只能从小往上升
        /// </summary>
        public int GradeSort { get; set; }

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