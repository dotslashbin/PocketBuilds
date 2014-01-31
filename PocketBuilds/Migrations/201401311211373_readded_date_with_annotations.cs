namespace PocketBuilds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class readded_date_with_annotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BuildOrder", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BuildOrder", "DateAdded");
        }
    }
}
