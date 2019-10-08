namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createControlCode : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PublishedCourses");
            AddColumn("dbo.PublishedCourses", "CreateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.PublishedCourses", "ModifyTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.PublishedCourses", "IsRemoved", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PublishedCourses", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.PublishedCourses", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PublishedCourses");
            AlterColumn("dbo.PublishedCourses", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.PublishedCourses", "IsRemoved");
            DropColumn("dbo.PublishedCourses", "ModifyTime");
            DropColumn("dbo.PublishedCourses", "CreateTime");
            AddPrimaryKey("dbo.PublishedCourses", "Id");
        }
    }
}
