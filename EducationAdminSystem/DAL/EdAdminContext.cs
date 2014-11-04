using EducationAdminSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EducationAdminSystem.DAL
{
    public class EdAdminContext :DbContext
    {
        public EdAdminContext()
            : base("EdAdminContext")
        {
        }

        //学年
        public DbSet<SchoolYear> SchoolYears { get; set; }
        //学期
        public DbSet<SchoolTerm> SchoolTerms { get; set; }
             
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassInSchool> Classes { get; set; }

        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentHomeworkFile> HomeworkFiles { get; set; }

        public DbSet<TeacherCourse> TeacherCourseInfos { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<ClassGradeRelationInfo> ClassGrades { get; set; }
        //班主任与班级关系集
        public DbSet<TeacherChargeClass> ClassCharges { get; set; }
        //班级与学生的关系
        public DbSet<StudentClassRelationInfo> StudentClasses { get; set; }
        //教室与课程的关系
        public DbSet<CourseClassroomRelationInfo> CourseClassroomRelationInfoes { get; set; }

        //教师交的课与班级的关系
        public DbSet<TeacheClassCourse> TeacheClassCourses { get; set; }

        public DbSet<HomeworkOpen> HomeworkOpens { get; set; }
        public DbSet<Courseware> Coursewares { get; set; }

        public DbSet<AdminAction> AdminActions { get; set; }
        public DbSet<Adminstrator> Adminstrators { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }

    }
}