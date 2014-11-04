namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHomeworkClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        HomeworkId = c.Int(nullable: false, identity: true),
                        IsExpired = c.Int(nullable: false, defaultValue: 0),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        HomeworkTitle = c.String(nullable: false, maxLength: 200),
                        HomeworkDescription = c.String(maxLength: 1000),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        TeacherCourse_TeacherCourseId = c.Int(),
                    })
                .PrimaryKey(t => t.HomeworkId)
                .ForeignKey("dbo.TeacherCourses", t => t.TeacherCourse_TeacherCourseId)
                .Index(t => t.TeacherCourse_TeacherCourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Homework", "TeacherCourse_TeacherCourseId", "dbo.TeacherCourses");
            DropIndex("dbo.Homework", new[] { "TeacherCourse_TeacherCourseId" });
            DropTable("dbo.Homework");
        }
    }
}
