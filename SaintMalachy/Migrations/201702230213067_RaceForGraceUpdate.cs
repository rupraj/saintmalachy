namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaceForGraceUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RaceForGraces", "DateOfBirth", c => c.String());
            DropColumn("dbo.RaceForGraces", "DOB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RaceForGraces", "DOB", c => c.String());
            DropColumn("dbo.RaceForGraces", "DateOfBirth");
        }
    }
}
