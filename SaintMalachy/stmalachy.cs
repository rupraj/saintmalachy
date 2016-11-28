namespace SaintMalachy
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class stmalachy : DbContext
    {
        // Your context has been configured to use a 'stmalachy' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SaintMalachy.stmalachy' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'stmalachy' 
        // connection string in the application configuration file.
        public stmalachy()
            : base("name=stmalachy")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<BaptismRequestModel> BaptismRequest { get; set; }
        public virtual DbSet<FuneralHomeInfoModel> FuneralHomeInfo { get; set; }
        public virtual DbSet<FuneralRequestModel> FuneralRequest { get; set; }
        public virtual DbSet<ReligiousEdModel> ReligiousEd { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogged { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}