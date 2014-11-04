namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseObligatory1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Obligatory", c => c.Int(nullable: false, defaultValue:1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Obligatory");
        }
    }
}
