namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDraftSchema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assets", "Cost", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Assets", "Quantity", c => c.Int());
            AlterColumn("dbo.Assets", "PurchaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Assets", "PurchaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Assets", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Assets", "Cost");
        }
    }
}
