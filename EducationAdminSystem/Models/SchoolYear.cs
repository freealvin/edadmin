using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class SchoolYear
    {
        public int SchoolYearId { get; set; }
        [Display(Name="起始年份")]
        public int StartYear { get; set; }
        [Display(Name = "结束年份")]
        public int EndYear { get; set; }

        [Display(Name="学期名称")]
        [StringLength(50)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }
        //是不是设为当前学年，默认为1，其他则设为0
        public int IsCurrent { get; set; }
        public int Deleted { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        [StringLength(50)]
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        [Display(Name="备注")]
        public string Description { get; set; }

        public virtual ICollection<SchoolTerm> SchooTerms { get; set; }
    }
}