namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdministrators : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adminstrators",
                c => new
                    {
                        AdminstratorId = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(nullable: false, maxLength: 50),
                        Tel = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        Actionlist = c.String(),
                        NavList = c.String(),
                        LastLogin = c.DateTime(nullable: false),
                        LastIp = c.String(maxLength: 20),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AdminstratorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adminstrators");
        }
    }
}
