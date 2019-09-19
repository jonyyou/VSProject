namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PublishedCourses", "DepartmentId", c => c.String(maxLength: 8, unicode: false));
            CreateIndex("dbo.PublishedCourses", "DepartmentId");
            AddForeignKey("dbo.PublishedCourses", "DepartmentId", "dbo.Departments", "DepartmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PublishedCourses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.PublishedCourses", new[] { "DepartmentId" });
            DropColumn("dbo.PublishedCourses", "DepartmentId");
        }
    }
}
