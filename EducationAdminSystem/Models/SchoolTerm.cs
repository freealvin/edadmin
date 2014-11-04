using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class SchoolTerm
    {
        public int SchoolTermId { get; set; }
        public virtual SchoolYear SchoolYear { get; set; }



        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        /// <summary>
        /// 是不是当前学期，默认为1：当前学期，0：非当前学期
        /// </summary>
        public int IsCurrent { get; set; }
        /// <summary>
        /// 标记删除
        /// </summary>
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