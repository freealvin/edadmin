using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    /// <summary>
    /// 班主任与班级的关系表
    /// </summary>
    public class TeacherChargeClass
    {
        public int TeacherChargeClassId { get; set; }
        public virtual Teacher ClassCharger { get; set; }
        public virtual ClassInSchool Class { get; set; }

        public virtual SchoolYear SchoolYear { get; set; }

        /// <summary>
        /// 学期中间是否换过班主任，换过为1：未换过：0， 默认为0
        /// </summary>
        public int ChangeInMiddle { get; set; }
        /// <summary>
        /// 如果学期中间换过班主任，之前的班主任管理表中的IsExpired设为1，否则一直为0指导学年结束
        /// </summary>
        public int IsExpired { get; set; }
        /// <summary>
        /// 标记删除
        /// </summary>
        public int Deleted { get; set; }
        public DateTime StartTime { get; set; }
        //结束时间默认为学年结束时间，所以应该先选择学年
        public DateTime EndTime { get; set; }


        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Description { get; set; }
    }
}