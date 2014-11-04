namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminRoleClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminRoles",
                c => new
                    {
                        AdminRoleId = c.Int(nullable: false, identity: true),
                        ActionList = c.String(),
                        RoleName = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                        LastIp = c.String(maxLength: 20),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AdminRoleId);
            
            AddColumn("dbo.Adminstrators", "RoleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Adminstrators", "RoleTypeId");
            AddForeignKey("dbo.Adminstrators", "RoleTypeId", "dbo.AdminRoles", "AdminRoleId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adminstrators", "RoleTypeId", "dbo.AdminRoles");
            DropIndex("dbo.Adminstrators", new[] { "RoleTypeId" });
            DropColumn("dbo.Adminstrators", "RoleTypeId");
            DropTable("dbo.AdminRoles");
        }
    }
}
