using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }

        [StringLength(50)]
        public string RoomName { get; set; }

        [StringLength(50)]
        public string RoomAddress { get; set; }

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