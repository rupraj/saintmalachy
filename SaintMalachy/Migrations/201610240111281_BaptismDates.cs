namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaptismDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BaptismRequestModels", "BaptismDate", c => c.String());
            AddColumn("dbo.BaptismRequestModels", "DinnerDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaptismRequestModels", "DinnerDate");
            DropColumn("dbo.BaptismRequestModels", "BaptismDate");
        }
    }
}
