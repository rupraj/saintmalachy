namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedOn1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BaptismRequestModels", "CreatedOn", c => c.String(nullable:false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaptismRequestModels", "CreatedOn");
        }
    }
}
