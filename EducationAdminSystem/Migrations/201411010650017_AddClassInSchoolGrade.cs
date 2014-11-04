namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassInSchoolGrade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClassInSchools", "Grade_GradeId", c => c.Int());
            CreateIndex("dbo.ClassInSchools", "Grade_GradeId");
            AddForeignKey("dbo.ClassInSchools", "Grade_GradeId", "dbo.Grades", "GradeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassInSchools", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.ClassInSchools", new[] { "Grade_GradeId" });
            DropColumn("dbo.ClassInSchools", "Grade_GradeId");
        }
    }
}
