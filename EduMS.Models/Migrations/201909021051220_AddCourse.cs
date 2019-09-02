namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.String(nullable: false, maxLength: 8, unicode: false),
                        CourseName = c.String(nullable: false, maxLength: 20),
                        Credits = c.Double(nullable: false),
                        Hours = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.String(maxLength: 8, unicode: false),
                        StuId = c.String(maxLength: 12, unicode: false),
                        Score = c.Int(nullable: false),
                        Grade = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Students", t => t.StuId)
                .Index(t => t.CourseId)
                .Index(t => t.StuId);
            
            CreateTable(
                "dbo.PublishedCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.String(maxLength: 8, unicode: false),
                        TeaId = c.String(maxLength: 12, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeaId)
                .Index(t => t.CourseId)
                .Index(t => t.TeaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PublishedCourses", "TeaId", "dbo.Teachers");
            DropForeignKey("dbo.PublishedCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Enrollments", "StuId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.PublishedCourses", new[] { "TeaId" });
            DropIndex("dbo.PublishedCourses", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "StuId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropTable("dbo.PublishedCourses");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Courses");
        }
    }
}
