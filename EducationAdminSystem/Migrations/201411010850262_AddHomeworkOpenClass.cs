namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHomeworkOpenClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeworkOpens",
                c => new
                    {
                        HomeworkOpenId = c.Int(nullable: false, identity: true),
                        Open = c.Int(nullable: false, defaultValue:1),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Class_ClassInSchoolId = c.Int(),
                        Homework_HomeworkId = c.Int(),
                    })
                .PrimaryKey(t => t.HomeworkOpenId)
                .ForeignKey("dbo.ClassInSchools", t => t.Class_ClassInSchoolId)
                .ForeignKey("dbo.Homework", t => t.Homework_HomeworkId)
                .Index(t => t.Class_ClassInSchoolId)
                .Index(t => t.Homework_HomeworkId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeworkOpens", "Homework_HomeworkId", "dbo.Homework");
            DropForeignKey("dbo.HomeworkOpens", "Class_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.HomeworkOpens", new[] { "Homework_HomeworkId" });
            DropIndex("dbo.HomeworkOpens", new[] { "Class_ClassInSchoolId" });
            DropTable("dbo.HomeworkOpens");
        }
    }
}
