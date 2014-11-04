namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveClassStudents : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ClassInSchool_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.Students", new[] { "ClassInSchool_ClassInSchoolId" });
            DropColumn("dbo.Students", "ClassInSchool_ClassInSchoolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ClassInSchool_ClassInSchoolId", c => c.Int());
            CreateIndex("dbo.Students", "ClassInSchool_ClassInSchoolId");
            AddForeignKey("dbo.Students", "ClassInSchool_ClassInSchoolId", "dbo.ClassInSchools", "ClassInSchoolId");
        }
    }
}
