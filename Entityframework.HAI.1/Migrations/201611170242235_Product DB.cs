namespace Entityframework.HAI._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "User",
                c => new
                {
                    UserId = c.Int(nullable: false, identity: true),
                    SignInDate = c.Int(),
                })
                .PrimaryKey(t => t.UserId);
        }
        
        public override void Down()
        {
            DropTable("User");
        }
    }
}
