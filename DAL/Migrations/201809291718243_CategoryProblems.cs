namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryProblems : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Assets", "CategoryId", "dbo.Categories");
            //DropIndex("dbo.Assets", new[] { "CategoryId" });
            //AlterColumn("dbo.Assets", "CategoryId", c => c.Int());
            //CreateIndex("dbo.Assets", "CategoryId");
            //AddForeignKey("dbo.Assets", "CategoryId", "dbo.Categories", "CategoryId");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Assets", "CategoryId", "dbo.Categories");
            //DropIndex("dbo.Assets", new[] { "CategoryId" });
            //AlterColumn("dbo.Assets", "CategoryId", c => c.Int(nullable: false));
            //CreateIndex("dbo.Assets", "CategoryId");
            //AddForeignKey("dbo.Assets", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
