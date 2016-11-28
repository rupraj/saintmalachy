namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReligiousEdWantTohelp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReligiousEdModels", "WantToHelp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReligiousEdModels", "WantToHelp");
        }
    }
}
