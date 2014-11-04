namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGradeGradeSort : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "GradeSort", c => c.Int(nullable: false, defaultValue:1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grades", "GradeSort");
        }
    }
}
