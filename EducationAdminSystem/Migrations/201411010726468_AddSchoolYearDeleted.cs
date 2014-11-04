namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolYearDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SchoolYears", "Deleted", c => c.Int(nullable: false, defaultValue:0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SchoolYears", "Deleted");
        }
    }
}
