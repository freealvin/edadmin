namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGradeClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(nullable: false, maxLength: 50),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Grades");
        }
    }
}
