namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logging2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ErrorLogged", "modulename", c => c.String());
            DropColumn("dbo.ErrorLogged", "modeulename");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ErrorLogged", "modeulename", c => c.String());
            DropColumn("dbo.ErrorLogged", "modulename");
        }
    }
}
