namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyOriginClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OriginClasses", "DepartmentId", c => c.String(maxLength: 8, unicode: false));
            CreateIndex("dbo.OriginClasses", "DepartmentId");
            AddForeignKey("dbo.OriginClasses", "DepartmentId", "dbo.Departments", "DepartmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OriginClasses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.OriginClasses", new[] { "DepartmentId" });
            DropColumn("dbo.OriginClasses", "DepartmentId");
        }
    }
}
