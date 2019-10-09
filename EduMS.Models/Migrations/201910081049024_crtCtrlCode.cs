namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class crtCtrlCode : DbMigration
    {
        public override void Up()
        {
            // DropPrimaryKey("dbo.PublishedCourses");
            CreateTable(
                "dbo.ControlCodes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IfSelectCourse = c.String(nullable: false, maxLength: 1),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PublishedCourses", "Semester", c => c.String());
            AddColumn("dbo.PublishedCourses", "CreateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.PublishedCourses", "ModifyTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.PublishedCourses", "IsRemoved", c => c.Boolean(nullable: false));
            AddColumn("dbo.PublishedCourses", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.PublishedCourses", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PublishedCourses");
            AlterColumn("dbo.PublishedCourses", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.PublishedCourses", "IsRemoved");
            DropColumn("dbo.PublishedCourses", "ModifyTime");
            DropColumn("dbo.PublishedCourses", "CreateTime");
            DropColumn("dbo.PublishedCourses", "Semester");
            DropTable("dbo.ControlCodes");
            AddPrimaryKey("dbo.PublishedCourses", "Id");
        }
    }
}
