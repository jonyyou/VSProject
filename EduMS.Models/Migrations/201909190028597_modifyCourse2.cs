namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyCourse2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseSpecialty", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CourseSpecialty");
        }
    }
}
