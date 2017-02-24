namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaceForGrace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RaceForGraces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        DOB = c.String(),
                        Interest = c.String(),
                        CreatedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RaceForGraces");
        }
    }
}
