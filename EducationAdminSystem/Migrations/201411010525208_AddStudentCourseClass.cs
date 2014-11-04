namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentCourseClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(maxLength: 50),
                        BeginDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsClosed = c.Int(nullable: false, defaultValue: 0),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CourseType = c.Int(nullable: false),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentAccount = c.String(nullable: false, maxLength: 50),
                        Password = c.String(maxLength: 50),
                        StudentName = c.String(maxLength: 50),
                        Gender = c.Int(nullable: false),
                        Age = c.Int(nullable: true),
                        Address = c.String(maxLength: 100),
                        HomeNumber = c.String(maxLength: 15),
                        FatherTel = c.String(maxLength: 15),
                        MotherTel = c.String(maxLength: 15),
                        IdNumber = c.String(maxLength: 20),
                        CreateUser = c.String(maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
