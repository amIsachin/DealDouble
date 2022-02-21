namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActionPictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AuctionID = c.Int(nullable: false),
                        PictureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pictures", t => t.PictureID, cascadeDelete: true)
                .ForeignKey("dbo.Auctions", t => t.AuctionID, cascadeDelete: true)
                .Index(t => t.AuctionID)
                .Index(t => t.PictureID);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Auctions", "PictureURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "PictureURL", c => c.String());
            DropForeignKey("dbo.ActionPictures", "AuctionID", "dbo.Auctions");
            DropForeignKey("dbo.ActionPictures", "PictureID", "dbo.Pictures");
            DropIndex("dbo.ActionPictures", new[] { "PictureID" });
            DropIndex("dbo.ActionPictures", new[] { "AuctionID" });
            DropTable("dbo.Pictures");
            DropTable("dbo.ActionPictures");
        }
    }
}
