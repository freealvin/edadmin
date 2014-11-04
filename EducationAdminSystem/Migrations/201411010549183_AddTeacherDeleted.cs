namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Deleted", c => c.Int(nullable: false, defaultValue:0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Deleted");
        }
    }
}
