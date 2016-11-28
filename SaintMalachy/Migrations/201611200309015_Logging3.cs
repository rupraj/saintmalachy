namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logging3 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ErrorLogged", newName: "ErrorLogs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ErrorLogs", newName: "ErrorLogged");
        }
    }
}
