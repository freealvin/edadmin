namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacheClassCourseClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacheClassCourses",
                c => new
                    {
                        TeacheClassCourseId = c.Int(nullable: false, identity: true),
                        IsExpired = c.Int(nullable: false, defaultValue:0),
                        Deleted = c.Int(nullable: false, defaultValue: 0),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                        Class_ClassInSchoolId = c.Int(),
                        TeacherCourseRelation_TeacherCourseId = c.Int(),
                    })
                .PrimaryKey(t => t.TeacheClassCourseId)
                .ForeignKey("dbo.ClassInSchools", t => t.Class_ClassInSchoolId)
                .ForeignKey("dbo.TeacherCourses", t => t.TeacherCourseRelation_TeacherCourseId)
                .Index(t => t.Class_ClassInSchoolId)
                .Index(t => t.TeacherCourseRelation_TeacherCourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacheClassCourses", "TeacherCourseRelation_TeacherCourseId", "dbo.TeacherCourses");
            DropForeignKey("dbo.TeacheClassCourses", "Class_ClassInSchoolId", "dbo.ClassInSchools");
            DropIndex("dbo.TeacheClassCourses", new[] { "TeacherCourseRelation_TeacherCourseId" });
            DropIndex("dbo.TeacheClassCourses", new[] { "Class_ClassInSchoolId" });
            DropTable("dbo.TeacheClassCourses");
        }
    }
}
