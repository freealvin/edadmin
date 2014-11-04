namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassGradeRelationInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassGradeRelationInfoes",
                c => new
                    {
                        ClassGradeRelationInfoId = c.Int(nullable: false, identity: true),
                        IsExpired = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                        Class_ClassInSchoolId = c.Int(),
                        Grade_GradeId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassGradeRelationInfoId)
                .ForeignKey("dbo.ClassInSchools", t => t.Class_ClassInSchoolId)
                .ForeignKey("dbo.Grades", t => t.Grade_GradeId)
                .Index(t => t.Class_ClassInSchoolId)
                .Index(t => t.Grade_GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassGradeRelationInfoes", "Grade_GradeId", "dbo.Grades");
            DropForeignKey("dbo.ClassGradeRelationInfoes", "Class_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.ClassGradeRelationInfoes", new[] { "Grade_GradeId" });
            DropIndex("dbo.ClassGradeRelationInfoes", new[] { "Class_ClassInSchoolId" });
            DropTable("dbo.ClassGradeRelationInfoes");
        }
    }
}
