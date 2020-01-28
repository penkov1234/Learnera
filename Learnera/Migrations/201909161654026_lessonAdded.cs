namespace Learnera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lessonAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "Lesson", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "Lesson");
        }
    }
}
