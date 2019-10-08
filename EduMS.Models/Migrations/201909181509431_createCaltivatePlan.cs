namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createCaltivatePlan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Courses", "CreateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "ModifyTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "IsRemoved", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "IsRemoved");
            DropColumn("dbo.Courses", "ModifyTime");
            DropColumn("dbo.Courses", "CreateTime");
            DropColumn("dbo.Courses", "Id");
        }
    }
}
