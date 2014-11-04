namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveClassInSchoolGrade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClassInSchools", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.ClassInSchools", new[] { "Grade_GradeId" });
            DropColumn("dbo.ClassInSchools", "Grade_GradeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClassInSchools", "Grade_GradeId", c => c.Int());
            CreateIndex("dbo.ClassInSchools", "Grade_GradeId");
            AddForeignKey("dbo.ClassInSchools", "Grade_GradeId", "dbo.Grades", "GradeId");
        }
    }
}
