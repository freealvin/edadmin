using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class StudentHomeworkFile
    {
        public int StudentHomeworkFileId { get; set; }
        [Required, ForeignKey("Homework")]
        public int HomeworkId { get; set; }
        public virtual Homework Homework { get; set; }
        public virtual Student Student { get; set; }
        public float Size { get; set; }
        public string FileUrl { get; set; }
        public string Extention { get; set; }
        public DateTime UploadTime { get; set; }


        /// <summary>
        /// 作业是否已经被老师收了
        /// </summary>
        public int IsCollected { get; set; }
        //作业描述
        public string FileDescription { get; set; }
        public string Description { get; set; }

        public float Score { get; set; }
        /// <summary>
        /// 评阅时间
        /// </summary>
        public DateTime EvaluteTime { get; set; }
        /// <summary>
        /// 评语
        /// </summary>
        public string JudgeNote { get; set; }
    }
}