namespace PocketBuilds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuildOrder",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BuildOrderID = c.Int(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BuildOrder", t => t.BuildOrderID, cascadeDelete: true)
                .Index(t => t.BuildOrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "BuildOrderID", "dbo.BuildOrder");
            DropIndex("dbo.Note", new[] { "BuildOrderID" });
            DropTable("dbo.Note");
            DropTable("dbo.BuildOrder");
        }
    }
}
