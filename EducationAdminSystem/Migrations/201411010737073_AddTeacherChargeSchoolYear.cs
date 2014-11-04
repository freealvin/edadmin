namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherChargeSchoolYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeacherChargeClasses", "SchoolYear_SchoolYearId", c => c.Int());
            CreateIndex("dbo.TeacherChargeClasses", "SchoolYear_SchoolYearId");
            AddForeignKey("dbo.TeacherChargeClasses", "SchoolYear_SchoolYearId", "dbo.SchoolYears", "SchoolYearId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherChargeClasses", "SchoolYear_SchoolYearId", "dbo.SchoolYears");
            DropIndex("dbo.TeacherChargeClasses", new[] { "SchoolYear_SchoolYearId" });
            DropColumn("dbo.TeacherChargeClasses", "SchoolYear_SchoolYearId");
        }
    }
}
