namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseClassroomRelationInfoClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseClassroomRelationInfoes",
                c => new
                    {
                        CourseClassroomRelationInfoId = c.Int(nullable: false, identity: true),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Classroom_ClassroomId = c.Int(),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseClassroomRelationInfoId)
                .ForeignKey("dbo.Classrooms", t => t.Classroom_ClassroomId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Classroom_ClassroomId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseClassroomRelationInfoes", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseClassroomRelationInfoes", "Classroom_ClassroomId", "dbo.Classrooms");
            DropIndex("dbo.CourseClassroomRelationInfoes", new[] { "Course_CourseId" });
            DropIndex("dbo.CourseClassroomRelationInfoes", new[] { "Classroom_ClassroomId" });
            DropTable("dbo.CourseClassroomRelationInfoes");
        }
    }
}
