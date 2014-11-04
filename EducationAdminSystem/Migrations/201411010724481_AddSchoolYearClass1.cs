namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolYearClass1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolYears",
                c => new
                    {
                        SchoolYearId = c.Int(nullable: false, identity: true),
                        StartYear = c.Int(nullable: false),
                        EndYear = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsCurrent = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SchoolYearId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SchoolYears");
        }
    }
}
