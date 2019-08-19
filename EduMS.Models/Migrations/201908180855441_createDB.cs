namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.String(nullable: false, maxLength: 12, unicode: false),
                        AdminName = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false),
                        Telephone = c.String(nullable: false, maxLength: 11, unicode: false),
                        IDNumber = c.String(nullable: false, maxLength: 18, unicode: false),
                        Pwd = c.String(nullable: false, maxLength: 12, unicode: false),
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BannerId = c.Int(nullable: false),
                        Image = c.String(),
                        Url = c.String(),
                        Remark = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.String(nullable: false, maxLength: 8, unicode: false),
                        DepartmentName = c.String(nullable: false, maxLength: 20),
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SpecialityId = c.String(nullable: false, maxLength: 8, unicode: false),
                        SpecialityName = c.String(nullable: false, maxLength: 20),
                        DepartmentId = c.String(maxLength: 8, unicode: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                        NewsCategory_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewsCategories", t => t.NewsCategory_Id)
                .Index(t => t.NewsCategory_Id);
            
            CreateTable(
                "dbo.NewsCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CategoryName = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OriginClasses",
                c => new
                    {
                        ClassId = c.String(nullable: false, maxLength: 10, unicode: false),
                        ClassName = c.String(maxLength: 30),
                        MonitorId = c.String(maxLength: 12),
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StuId = c.String(nullable: false, maxLength: 12, unicode: false),
                        StuName = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false),
                        Telephone = c.String(nullable: false, maxLength: 11, unicode: false),
                        IDNumber = c.String(nullable: false, maxLength: 18, unicode: false),
                        Pwd = c.String(nullable: false, maxLength: 12, unicode: false),
                        Major = c.String(nullable: false),
                        ClassId = c.String(maxLength: 10, unicode: false),
                        DepartmentId = c.String(maxLength: 8, unicode: false),
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StuId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.OriginClasses", t => t.ClassId)
                .Index(t => t.ClassId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeaId = c.String(nullable: false, maxLength: 12, unicode: false),
                        TeaName = c.String(nullable: false, maxLength: 30),
                        Gender = c.String(nullable: false),
                        Telephone = c.String(nullable: false, maxLength: 11, unicode: false),
                        IDNumber = c.String(nullable: false, maxLength: 18, unicode: false),
                        Pwd = c.String(nullable: false, maxLength: 12, unicode: false),
                        DepartmentId = c.String(maxLength: 8, unicode: false),
                        Id = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyTime = c.DateTime(nullable: false),
                        IsRemoved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TeaId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "ClassId", "dbo.OriginClasses");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.News", "NewsCategory_Id", "dbo.NewsCategories");
            DropForeignKey("dbo.Specialities", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropIndex("dbo.News", new[] { "NewsCategory_Id" });
            DropIndex("dbo.Specialities", new[] { "DepartmentId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.OriginClasses");
            DropTable("dbo.NewsCategories");
            DropTable("dbo.News");
            DropTable("dbo.Specialities");
            DropTable("dbo.Departments");
            DropTable("dbo.Banners");
            DropTable("dbo.Admins");
        }
    }
}
