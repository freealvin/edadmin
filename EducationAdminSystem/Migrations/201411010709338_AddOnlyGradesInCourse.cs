namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOnlyGradesInCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "OnlyGrades", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "OnlyGrades");
        }
    }
}
