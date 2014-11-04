namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentClassRelationInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentClassRelationInfoes",
                c => new
                    {
                        StudentClassRelationInfoId = c.Int(nullable: false, identity: true),
                        IsExpired = c.Int(nullable: false, defaultValue:0),
                        Deleted = c.Int(nullable: false,defaultValue:0),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Class_ClassInSchoolId = c.Int(),
                        SchooTerm_SchoolTermId = c.Int(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentClassRelationInfoId)
                .ForeignKey("dbo.ClassInSchools", t => t.Class_ClassInSchoolId)
                .ForeignKey("dbo.SchoolTerms", t => t.SchooTerm_SchoolTermId)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Class_ClassInSchoolId)
                .Index(t => t.SchooTerm_SchoolTermId)
                .Index(t => t.Student_StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentClassRelationInfoes", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentClassRelationInfoes", "SchooTerm_SchoolTermId", "dbo.SchoolTerms");
            DropForeignKey("dbo.StudentClassRelationInfoes", "Class_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.StudentClassRelationInfoes", new[] { "Student_StudentID" });
            DropIndex("dbo.StudentClassRelationInfoes", new[] { "SchooTerm_SchoolTermId" });
            DropIndex("dbo.StudentClassRelationInfoes", new[] { "Class_ClassInSchoolId" });
            DropTable("dbo.StudentClassRelationInfoes");
        }
    }
}
