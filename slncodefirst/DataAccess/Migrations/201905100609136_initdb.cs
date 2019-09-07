namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        Content = c.String(maxLength: 4000),
                        WriterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.writer", t => t.WriterID, cascadeDelete: true)
                .Index(t => t.WriterID);
            
            CreateTable(
                "dbo.writer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "WriterID", "dbo.writer");
            DropIndex("dbo.Recipes", new[] { "WriterID" });
            DropTable("dbo.writer");
            DropTable("dbo.Recipes");
        }
    }
}
