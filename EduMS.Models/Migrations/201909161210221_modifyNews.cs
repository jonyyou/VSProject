namespace EduMS.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyNews : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.News", "NewsCategory_Id", "dbo.NewsCategories");
            DropIndex("dbo.News", new[] { "NewsCategory_Id" });
            RenameColumn(table: "dbo.News", name: "NewsCategory_Id", newName: "CategoryId");
            DropPrimaryKey("dbo.NewsCategories");
            AddColumn("dbo.NewsCategories", "CategoryId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.News", "CategoryId", c => c.String(maxLength: 128));
            AlterColumn("dbo.NewsCategories", "CategoryName", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.NewsCategories", "CategoryId");
            CreateIndex("dbo.News", "CategoryId");
            AddForeignKey("dbo.News", "CategoryId", "dbo.NewsCategories", "CategoryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "CategoryId", "dbo.NewsCategories");
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropPrimaryKey("dbo.NewsCategories");
            AlterColumn("dbo.NewsCategories", "CategoryName", c => c.String());
            AlterColumn("dbo.News", "CategoryId", c => c.Guid());
            DropColumn("dbo.NewsCategories", "CategoryId");
            AddPrimaryKey("dbo.NewsCategories", "Id");
            RenameColumn(table: "dbo.News", name: "CategoryId", newName: "NewsCategory_Id");
            CreateIndex("dbo.News", "NewsCategory_Id");
            AddForeignKey("dbo.News", "NewsCategory_Id", "dbo.NewsCategories", "Id");
        }
    }
}
