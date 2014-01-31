namespace PocketBuilds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removed_date_related_fields_on_models : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BuildOrder", "DateAdded");
            DropColumn("dbo.BuildOrder", "LastUpdate");
            DropColumn("dbo.Note", "DateAdded");
            DropColumn("dbo.Note", "LastUpdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Note", "LastUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Note", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.BuildOrder", "LastUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BuildOrder", "DateAdded", c => c.DateTime(nullable: false));
        }
    }
}
