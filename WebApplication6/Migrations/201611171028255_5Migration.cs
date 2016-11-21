namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5Migration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.QLBlogs", newName: "QLBlog");
            DropForeignKey("dbo.QLBlogs", "Category_Id", "dbo.Categories");
            DropIndex("dbo.QLBlog", new[] { "Category_Id" });
            RenameColumn(table: "dbo.QLBlog", name: "Category_Id", newName: "CategoryId");
            AlterColumn("dbo.QLBlog", "CategoryId", c => c.Guid(nullable: false));
            CreateIndex("dbo.QLBlog", "CategoryId");
            AddForeignKey("dbo.QLBlog", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QLBlog", "CategoryId", "dbo.Categories");
            DropIndex("dbo.QLBlog", new[] { "CategoryId" });
            AlterColumn("dbo.QLBlog", "CategoryId", c => c.Guid());
            RenameColumn(table: "dbo.QLBlog", name: "CategoryId", newName: "Category_Id");
            CreateIndex("dbo.QLBlog", "Category_Id");
            AddForeignKey("dbo.QLBlogs", "Category_Id", "dbo.Categories", "Id");
            RenameTable(name: "dbo.QLBlog", newName: "QLBlogs");
        }
    }
}
