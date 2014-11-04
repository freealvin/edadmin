namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleNameStringLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminRoles", "RoleName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdminRoles", "RoleName", c => c.String());
        }
    }
}
