namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseEnrollmentClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseEnrollments",
                c => new
                    {
                        CourseEnrollmentId = c.Int(nullable: false, identity: true),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                        Course_CourseId = c.Int(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.CourseEnrollmentId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Course_CourseId)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseEnrollments", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.CourseEnrollments", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.CourseEnrollments", new[] { "Student_StudentID" });
            DropIndex("dbo.CourseEnrollments", new[] { "Course_CourseId" });
            DropTable("dbo.CourseEnrollments");
        }
    }
}
