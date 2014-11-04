namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCousewareClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coursewares",
                c => new
                    {
                        CoursewareId = c.Int(nullable: false, identity: true),
                        TeacherCourseId = c.Int(nullable: false),
                        FileName = c.String(),
                        FileUrl = c.String(),
                        Size = c.Int(nullable: false),
                        Extention = c.String(),
                        DownloadCount = c.Int(nullable: false),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CoursewareId)
                .ForeignKey("dbo.TeacherCourses", t => t.TeacherCourseId, cascadeDelete: true)
                .Index(t => t.TeacherCourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coursewares", "TeacherCourseId", "dbo.TeacherCourses");
            DropIndex("dbo.Coursewares", new[] { "TeacherCourseId" });
            DropTable("dbo.Coursewares");
        }
    }
}
