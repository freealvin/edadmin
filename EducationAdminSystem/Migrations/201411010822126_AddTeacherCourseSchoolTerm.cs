namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherCourseSchoolTerm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeacherCourses", "IsExpired", c => c.Int(nullable: false, defaultValue:0));
            AddColumn("dbo.TeacherCourses", "SchoolTerm_SchoolTermId", c => c.Int());
            CreateIndex("dbo.TeacherCourses", "SchoolTerm_SchoolTermId");
            AddForeignKey("dbo.TeacherCourses", "SchoolTerm_SchoolTermId", "dbo.SchoolTerms", "SchoolTermId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherCourses", "SchoolTerm_SchoolTermId", "dbo.SchoolTerms");
            DropIndex("dbo.TeacherCourses", new[] { "SchoolTerm_SchoolTermId" });
            DropColumn("dbo.TeacherCourses", "SchoolTerm_SchoolTermId");
            DropColumn("dbo.TeacherCourses", "IsExpired");
        }
    }
}
