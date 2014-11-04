namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherChargeIsExpired : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeacherChargeClasses", "ChangeInMiddle", c => c.Int(nullable: false, defaultValue:0));
            AddColumn("dbo.TeacherChargeClasses", "IsExpired", c => c.Int(nullable: false, defaultValue: 0));
            AddColumn("dbo.TeacherChargeClasses", "Deleted", c => c.Int(nullable: false, defaultValue: 0));
            AddColumn("dbo.TeacherChargeClasses", "StartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TeacherChargeClasses", "EndTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeacherChargeClasses", "EndTime");
            DropColumn("dbo.TeacherChargeClasses", "StartTime");
            DropColumn("dbo.TeacherChargeClasses", "Deleted");
            DropColumn("dbo.TeacherChargeClasses", "IsExpired");
            DropColumn("dbo.TeacherChargeClasses", "ChangeInMiddle");
        }
    }
}
