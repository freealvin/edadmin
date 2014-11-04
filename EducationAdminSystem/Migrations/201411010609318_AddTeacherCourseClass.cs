namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherCourseClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherCourses",
                c => new
                    {
                        TeacherCourseId = c.Int(nullable: false, identity: true),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                        Course_CourseId = c.Int(),
                        Teacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherCourseId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId)
                .Index(t => t.Course_CourseId)
                .Index(t => t.Teacher_TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherCourses", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherCourses", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.TeacherCourses", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.TeacherCourses", new[] { "Course_CourseId" });
            DropTable("dbo.TeacherCourses");
        }
    }
}
