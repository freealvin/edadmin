namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentHomeworkFileClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentHomeworkFiles",
                c => new
                    {
                        StudentHomeworkFileId = c.Int(nullable: false, identity: true),
                        HomeworkId = c.Int(nullable: false),
                        Size = c.Single(nullable: true),
                        FileUrl = c.String(),
                        Extention = c.String(),
                        UploadTime = c.DateTime(nullable: false),
                        IsCollected = c.Int(nullable: false, defaultValue:0),
                        FileDescription = c.String(),
                        Description = c.String(),
                        Score = c.Single(nullable: true),
                        EvaluteTime = c.DateTime(nullable: false),
                        JudgeNote = c.String(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentHomeworkFileId)
                .ForeignKey("dbo.Homework", t => t.HomeworkId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.HomeworkId)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentHomeworkFiles", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentHomeworkFiles", "HomeworkId", "dbo.Homework");
            DropIndex("dbo.StudentHomeworkFiles", new[] { "Student_StudentID" });
            DropIndex("dbo.StudentHomeworkFiles", new[] { "HomeworkId" });
            DropTable("dbo.StudentHomeworkFiles");
        }
    }
}
