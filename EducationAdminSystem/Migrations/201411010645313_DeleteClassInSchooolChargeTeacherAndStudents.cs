namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteClassInSchooolChargeTeacherAndStudents : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClassInSchools", "ChargeTeacher_TeacherId", "dbo.Teachers");
            DropIndex("dbo.ClassInSchools", new[] { "ChargeTeacher_TeacherId" });
            DropColumn("dbo.ClassInSchools", "ChargeTeacher_TeacherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClassInSchools", "ChargeTeacher_TeacherId", c => c.Int());
            CreateIndex("dbo.ClassInSchools", "ChargeTeacher_TeacherId");
            AddForeignKey("dbo.ClassInSchools", "ChargeTeacher_TeacherId", "dbo.Teachers", "TeacherId");
        }
    }
}
