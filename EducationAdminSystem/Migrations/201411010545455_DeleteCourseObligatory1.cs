namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCourseObligatory1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Obligatory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Obligatory", c => c.Int(nullable: false));
        }
    }
}
