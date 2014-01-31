namespace PocketBuilds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_required_fields_on_models : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BuildOrder", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.BuildOrder", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Note", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Note", "Content", c => c.String());
            AlterColumn("dbo.BuildOrder", "Content", c => c.String());
            AlterColumn("dbo.BuildOrder", "Title", c => c.String());
        }
    }
}
