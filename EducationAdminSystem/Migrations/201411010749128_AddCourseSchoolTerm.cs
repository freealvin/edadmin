namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseSchoolTerm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "SchoolTerm_SchoolTermId", c => c.Int());
            CreateIndex("dbo.Courses", "SchoolTerm_SchoolTermId");
            AddForeignKey("dbo.Courses", "SchoolTerm_SchoolTermId", "dbo.SchoolTerms", "SchoolTermId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SchoolTerm_SchoolTermId", "dbo.SchoolTerms");
            DropIndex("dbo.Courses", new[] { "SchoolTerm_SchoolTermId" });
            DropColumn("dbo.Courses", "SchoolTerm_SchoolTermId");
        }
    }
}
