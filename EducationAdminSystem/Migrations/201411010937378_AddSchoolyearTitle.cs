namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolyearTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SchoolYears", "Title", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SchoolYears", "Title");
        }
    }
}
