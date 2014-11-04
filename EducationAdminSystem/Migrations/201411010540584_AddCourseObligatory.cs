namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseObligatory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Obligatory", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Obligatory");
        }
    }
}
