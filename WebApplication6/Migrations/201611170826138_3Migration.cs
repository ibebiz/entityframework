namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3Migration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.QLBlogs");
            AlterColumn("dbo.QLBlogs", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.QLBlogs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.QLBlogs");
            AlterColumn("dbo.QLBlogs", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.QLBlogs", "Id");
        }
    }
}
