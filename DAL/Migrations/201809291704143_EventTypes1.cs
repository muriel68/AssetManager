namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTypes1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assets", "CategoryId", c => c.Int(nullable: true));
            //CreateIndex("dbo.Assets", "CategoryId");
            //AddForeignKey("dbo.Assets", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Assets", "CategoryId", "dbo.Categories");
            //DropIndex("dbo.Assets", new[] { "CategoryId" });
            //DropColumn("dbo.Assets", "CategoryId");
        }
    }
}
