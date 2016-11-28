namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedOn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BaptismRequestModels", "CreatedOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BaptismRequestModels", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
