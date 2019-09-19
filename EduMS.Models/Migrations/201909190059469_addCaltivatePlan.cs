namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCaltivatePlan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CaltivatePlans",
                c => new
                    {
                        Semester = c.String(nullable: false, maxLength: 128),
                        DepartmentId = c.String(maxLength: 8, unicode: false),
                        CourseId = c.String(maxLength: 8, unicode: false),
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Semester)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .Index(t => t.DepartmentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CaltivatePlans", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.CaltivatePlans", "CourseId", "dbo.Courses");
            DropIndex("dbo.CaltivatePlans", new[] { "CourseId" });
            DropIndex("dbo.CaltivatePlans", new[] { "DepartmentId" });
            DropTable("dbo.CaltivatePlans");
        }
    }
}
