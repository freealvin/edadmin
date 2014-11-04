namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassGradeYearStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClassInSchools", "Grade_GradeId", c => c.Int());
            AddColumn("dbo.ClassInSchools", "SchoolYear_SchoolYearId", c => c.Int());
            AddColumn("dbo.Students", "ClassInSchool_ClassInSchoolId", c => c.Int());
            CreateIndex("dbo.ClassInSchools", "Grade_GradeId");
            CreateIndex("dbo.ClassInSchools", "SchoolYear_SchoolYearId");
            CreateIndex("dbo.Students", "ClassInSchool_ClassInSchoolId");
            AddForeignKey("dbo.ClassInSchools", "Grade_GradeId", "dbo.Grades", "GradeId");
            AddForeignKey("dbo.ClassInSchools", "SchoolYear_SchoolYearId", "dbo.SchoolYears", "SchoolYearId");
            AddForeignKey("dbo.Students", "ClassInSchool_ClassInSchoolId", "dbo.ClassInSchools", "ClassInSchoolId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassInSchool_ClassInSchoolId", "dbo.ClassInSchools");
            DropForeignKey("dbo.ClassInSchools", "SchoolYear_SchoolYearId", "dbo.SchoolYears");
            DropForeignKey("dbo.ClassInSchools", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "ClassInSchool_ClassInSchoolId" });
            DropIndex("dbo.ClassInSchools", new[] { "SchoolYear_SchoolYearId" });
            DropIndex("dbo.ClassInSchools", new[] { "Grade_GradeId" });
            DropColumn("dbo.Students", "ClassInSchool_ClassInSchoolId");
            DropColumn("dbo.ClassInSchools", "SchoolYear_SchoolYearId");
            DropColumn("dbo.ClassInSchools", "Grade_GradeId");
        }
    }
}
