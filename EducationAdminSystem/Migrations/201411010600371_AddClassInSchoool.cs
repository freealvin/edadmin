namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassInSchoool : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassInSchools",
                c => new
                    {
                        ClassInSchoolId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        Deleted = c.Int(nullable: false),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        ChargeTeacher_TeacherId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassInSchoolId)
                .ForeignKey("dbo.Teachers", t => t.ChargeTeacher_TeacherId)
                .Index(t => t.ChargeTeacher_TeacherId);
            
            AddColumn("dbo.Students", "MyClass_ClassInSchoolId", c => c.Int());
            CreateIndex("dbo.Students", "MyClass_ClassInSchoolId");
            AddForeignKey("dbo.Students", "MyClass_ClassInSchoolId", "dbo.ClassInSchools", "ClassInSchoolId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "MyClass_ClassInSchoolId", "dbo.ClassInSchools");
            DropForeignKey("dbo.ClassInSchools", "ChargeTeacher_TeacherId", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "MyClass_ClassInSchoolId" });
            DropIndex("dbo.ClassInSchools", new[] { "ChargeTeacher_TeacherId" });
            DropColumn("dbo.Students", "MyClass_ClassInSchoolId");
            DropTable("dbo.ClassInSchools");
        }
    }
}
