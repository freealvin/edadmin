namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataTypeOfEnabledToBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminActions", "Enabled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminActions", "Enabled", c => c.Int(nullable: false));
        }
    }
}
