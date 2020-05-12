namespace FatimaFoundation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondLocalDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "DonationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tickets", "TourDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "TourDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tickets", "DonationDate");
        }
    }
}
