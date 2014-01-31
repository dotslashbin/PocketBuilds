namespace PocketBuilds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_date_related_fields_to_BuildOrder_and_Note : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuildOrder", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.BuildOrder", "LastUpdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Note", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Note", "LastUpdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "LastUpdate");
            DropColumn("dbo.Note", "DateAdded");
            DropColumn("dbo.BuildOrder", "LastUpdate");
            DropColumn("dbo.BuildOrder", "DateAdded");
        }
    }
}
