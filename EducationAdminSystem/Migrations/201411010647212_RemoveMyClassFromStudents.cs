namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMyClassFromStudents : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "MyClass_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.Students", new[] { "MyClass_ClassInSchoolId" });
            DropColumn("dbo.Students", "MyClass_ClassInSchoolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "MyClass_ClassInSchoolId", c => c.Int());
            CreateIndex("dbo.Students", "MyClass_ClassInSchoolId");
            AddForeignKey("dbo.Students", "MyClass_ClassInSchoolId", "dbo.ClassInSchools", "ClassInSchoolId");
        }
    }
}
