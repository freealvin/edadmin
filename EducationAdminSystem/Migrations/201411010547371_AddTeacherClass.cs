namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherAccout = c.String(nullable: false, maxLength: 50),
                        TeacherName = c.String(maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Title = c.String(maxLength: 50),
                        ZhiWu = c.String(maxLength: 50),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
