namespace EducationAdminSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassRoomClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(maxLength: 50),
                        RoomAddress = c.String(maxLength: 50),
                        Deleted = c.Int(nullable: false, defaultValue:0),
                        CreateUser = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateUser = c.String(maxLength: 50),
                        UpdateTime = c.DateTime(nullable: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ClassroomId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Classrooms");
        }
    }
}
