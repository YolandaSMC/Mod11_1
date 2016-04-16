namespace Mod11_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        ClassRoomID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        NumberPCs = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Floor = c.String(maxLength: 10),
                        Wing = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.ClassRoomID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Description = c.String(maxLength: 256),
                        ClassID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 25),
                        Description = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        Age = c.Int(nullable: false),
                        Studies = c.String(maxLength: 10),
                        ProjectID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Projects");
            DropTable("dbo.Courses");
            DropTable("dbo.ClassRooms");
        }
    }
}
