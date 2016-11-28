namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaptismModelCreatedOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BaptismRequestModels", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaptismRequestModels", "CreatedOn");
        }
    }
}
