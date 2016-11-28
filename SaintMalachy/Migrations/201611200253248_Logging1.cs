namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Logging1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ErrorLogged",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        stackTrace = c.String(),
                        model = c.String(),
                        modeulename = c.String(),
                        createdon = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ErrorLogged");
        }
    }
}
