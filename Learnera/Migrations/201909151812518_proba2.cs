namespace Learnera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class proba2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "LikesCount", c => c.Int(nullable: false));
            AddColumn("dbo.Replies", "LikesCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Replies", "LikesCount");
            DropColumn("dbo.Comments", "LikesCount");
        }
    }
}
