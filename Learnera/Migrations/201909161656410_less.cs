namespace Learnera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class less : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presentations", "Lesson", c => c.Int(nullable: false));
            DropColumn("dbo.Subjects", "Lesson");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subjects", "Lesson", c => c.Int(nullable: false));
            DropColumn("dbo.Presentations", "Lesson");
        }
    }
}
