namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BlogPosts", newName: "QLBlogs");
            DropPrimaryKey("dbo.QLBlogs");
            AlterColumn("dbo.QLBlogs", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.QLBlogs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.QLBlogs");
            AlterColumn("dbo.QLBlogs", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.QLBlogs", "Id");
            RenameTable(name: "dbo.QLBlogs", newName: "BlogPosts");
        }
    }
}
