namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReligiousEdCreatedOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReligiousEdModels", "CreatedOn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReligiousEdModels", "CreatedOn");
        }
    }
}
