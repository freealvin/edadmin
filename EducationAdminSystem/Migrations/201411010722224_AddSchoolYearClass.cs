namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolYearClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherChargeClasses",
                c => new
                    {
                        TeacherChargeClassId = c.Int(nullable: false, identity: true),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Class_ClassInSchoolId = c.Int(),
                        ClassCharger_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacherChargeClassId)
                .ForeignKey("dbo.ClassInSchools", t => t.Class_ClassInSchoolId)
                .ForeignKey("dbo.Teachers", t => t.ClassCharger_TeacherId)
                .Index(t => t.Class_ClassInSchoolId)
                .Index(t => t.ClassCharger_TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherChargeClasses", "ClassCharger_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.TeacherChargeClasses", "Class_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.TeacherChargeClasses", new[] { "ClassCharger_TeacherId" });
            DropIndex("dbo.TeacherChargeClasses", new[] { "Class_ClassInSchoolId" });
            DropTable("dbo.TeacherChargeClasses");
        }
    }
}
