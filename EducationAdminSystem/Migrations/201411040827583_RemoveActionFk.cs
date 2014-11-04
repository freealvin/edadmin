namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveActionFk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdminActions", "ParentId", "dbo.AdminActions");
            DropIndex("dbo.AdminActions", new[] { "ParentId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.AdminActions", "ParentId");
            AddForeignKey("dbo.AdminActions", "ParentId", "dbo.AdminActions", "AdminActionId");
        }
    }
}
