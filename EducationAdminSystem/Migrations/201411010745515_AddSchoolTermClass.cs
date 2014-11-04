namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchoolTermClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolTerms",
                c => new
                    {
                        SchoolTermId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsCurrent = c.Int(nullable: false, defaultValue:1),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        SchoolYear_SchoolYearId = c.Int(),
                    })
                .PrimaryKey(t => t.SchoolTermId)
                .ForeignKey("dbo.SchoolYears", t => t.SchoolYear_SchoolYearId)
                .Index(t => t.SchoolYear_SchoolYearId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SchoolTerms", "SchoolYear_SchoolYearId", "dbo.SchoolYears");
            DropIndex("dbo.SchoolTerms", new[] { "SchoolYear_SchoolYearId" });
            DropTable("dbo.SchoolTerms");
        }
    }
}
