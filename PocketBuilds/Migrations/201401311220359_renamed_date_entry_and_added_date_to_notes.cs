namespace PocketBuilds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renamed_date_entry_and_added_date_to_notes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuildOrder", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Note", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.BuildOrder", "DateAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BuildOrder", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Note", "DateCreated");
            DropColumn("dbo.BuildOrder", "DateCreated");
        }
    }
}
