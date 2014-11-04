namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminActionClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminActions",
                c => new
                    {
                        AdminActionId = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Code = c.String(),
                        Relevance = c.String(),
                        Enabled = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AdminActionId)
                .ForeignKey("dbo.AdminActions", t => t.ParentId)
                .Index(t => t.ParentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminActions", "ParentId", "dbo.AdminActions");
            DropIndex("dbo.AdminActions", new[] { "ParentId" });
            DropTable("dbo.AdminActions");
        }
    }
}
