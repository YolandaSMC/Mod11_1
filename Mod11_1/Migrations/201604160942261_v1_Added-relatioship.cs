namespace Mod11_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1_Addedrelatioship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "ClassRoom_ClassRoomID", c => c.Int());
            CreateIndex("dbo.Courses", "ClassRoom_ClassRoomID");
            CreateIndex("dbo.Students", "ProjectID");
            CreateIndex("dbo.Students", "CourseID");
            AddForeignKey("dbo.Courses", "ClassRoom_ClassRoomID", "dbo.ClassRooms", "ClassRoomID");
            AddForeignKey("dbo.Students", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
            AddForeignKey("dbo.Students", "ProjectID", "dbo.Projects", "ProjectID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Students", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "ClassRoom_ClassRoomID", "dbo.ClassRooms");
            DropIndex("dbo.Students", new[] { "CourseID" });
            DropIndex("dbo.Students", new[] { "ProjectID" });
            DropIndex("dbo.Courses", new[] { "ClassRoom_ClassRoomID" });
            DropColumn("dbo.Courses", "ClassRoom_ClassRoomID");
        }
    }
}
