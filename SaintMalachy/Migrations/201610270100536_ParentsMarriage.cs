namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentsMarriage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BaptismRequestModels", "ParentsMarried", c => c.String());
            AddColumn("dbo.BaptismRequestModels", "ChurchMarriage", c => c.String());
            AddColumn("dbo.BaptismRequestModels", "ParentsConfirmed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BaptismRequestModels", "ParentsConfirmed");
            DropColumn("dbo.BaptismRequestModels", "ChurchMarriage");
            DropColumn("dbo.BaptismRequestModels", "ParentsMarried");
        }
    }
}
