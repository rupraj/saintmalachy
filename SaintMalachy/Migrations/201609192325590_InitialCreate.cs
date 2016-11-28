namespace SaintMalachy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaptismRequestModels",
                c => new
                    {
                        BaptismRequestModelId = c.Int(nullable: false, identity: true),
                        ChildLastName = c.String(),
                        ChildName = c.String(),
                        ChildDateOfBirth = c.String(),
                        ChildPlaceOfBirth = c.String(),
                        FatherFullName = c.String(),
                        MotherFirstName = c.String(),
                        MotherMaidenName = c.String(),
                        Address = c.String(),
                        CityState = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        GodfatherName = c.String(),
                        GodfatherReligion = c.String(),
                        GodfatherConfirmed = c.String(),
                        GodmotherName = c.String(),
                        GodmotherReligion = c.String(),
                        GodmotherConfirmed = c.String(),
                        CommentsQuestions = c.String(),
                    })
                .PrimaryKey(t => t.BaptismRequestModelId);
            
            CreateTable(
                "dbo.FuneralHomeInfoModels",
                c => new
                    {
                        FuneralHomeInfoModelId = c.Int(nullable: false, identity: true),
                        NameOfDeceased = c.String(),
                        DateOfBirth = c.String(),
                        DateOfDeath = c.String(),
                        FuneralHome = c.String(),
                        DateOfFuneral = c.String(),
                        TimeOfFuneral = c.String(),
                        DateOfWake = c.String(),
                        TimeOfWake = c.String(),
                        ProcessionalSong = c.String(),
                        OtherHymns = c.String(),
                        ResponsorialPsalm = c.String(),
                        OffertorySong = c.String(),
                        CommunionSong = c.String(),
                        RecessionalSong = c.String(),
                        ReaderOneReading = c.String(),
                        ReaderTwoReading = c.String(),
                        PresentationOfGifts = c.String(),
                        Eulogy = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.FuneralHomeInfoModelId);
            
            CreateTable(
                "dbo.FuneralRequestModels",
                c => new
                    {
                        FuneralRequestModelId = c.Int(nullable: false, identity: true),
                        NameOfDeceased = c.String(),
                        Address = c.String(),
                        Age = c.Int(nullable: false),
                        DateOfBirth = c.String(),
                        DateOfDeath = c.String(),
                        KinRelationship = c.String(),
                        KinAddress = c.String(),
                        KinPhoneNumber = c.String(),
                        FuneralHome = c.String(),
                        FuneralHomeAddress = c.String(),
                        FuneralHomeUrl = c.String(),
                        DateOfFuneral = c.String(),
                        TimeOfFuneral = c.String(),
                        DateOfWake = c.String(),
                        TimeOfWake = c.String(),
                        Cemetry = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.FuneralRequestModelId);
            
            CreateTable(
                "dbo.ReligiousEdModels",
                c => new
                    {
                        ReligiousEdModelId = c.Int(nullable: false, identity: true),
                        TodayDate = c.String(),
                        FamilyName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        FamilyEmail = c.String(),
                        FatherFirstName = c.String(),
                        FatherLastName = c.String(),
                        FatherEmail = c.String(),
                        MotherFirstName = c.String(),
                        MotherLastName = c.String(),
                        MotherMaiden = c.String(),
                        MotherEmail = c.String(),
                        HelpTeaching = c.Boolean(nullable: false),
                        HelpHelping = c.Boolean(nullable: false),
                        HelpKidhelping = c.Boolean(nullable: false),
                        HelpInterest = c.String(),
                        Child1FirstName = c.String(),
                        Child1MiddleInitial = c.String(),
                        Child1LastName = c.String(),
                        Child1Grade = c.String(),
                        Child1DOB = c.String(),
                        Child1Email = c.String(),
                        Child1BaptismPlace = c.String(),
                        Child1BaptismDate = c.String(),
                        Child1EucharistPlace = c.String(),
                        Child1EucharistDate = c.String(),
                        sacrecords1 = c.String(),
                        reledchoice1 = c.String(),
                        Child2FirstName = c.String(),
                        Child2MiddleInitial = c.String(),
                        Child2LastName = c.String(),
                        Child2Grade = c.String(),
                        Child2DOB = c.String(),
                        Child2Email = c.String(),
                        Child2BaptismPlace = c.String(),
                        Child2BaptismDate = c.String(),
                        Child2EucharistPlace = c.String(),
                        Child2EucharistDate = c.String(),
                        sacrecords2 = c.String(),
                        reledchoice2 = c.String(),
                        Child3FirstName = c.String(),
                        Child3MiddleInitial = c.String(),
                        Child3LastName = c.String(),
                        Child3Grade = c.String(),
                        Child3DOB = c.String(),
                        Child3Email = c.String(),
                        Child3BaptismPlace = c.String(),
                        Child3BaptismDate = c.String(),
                        Child3EucharistPlace = c.String(),
                        Child3EucharistDate = c.String(),
                        sacrecords3 = c.String(),
                        reledchoice3 = c.String(),
                        Child4FirstName = c.String(),
                        Child4MiddleInitial = c.String(),
                        Child4LastName = c.String(),
                        Child4Grade = c.String(),
                        Child4DOB = c.String(),
                        Child4Email = c.String(),
                        Child4BaptismPlace = c.String(),
                        Child4BaptismDate = c.String(),
                        Child4EucharistPlace = c.String(),
                        Child4EucharistDate = c.String(),
                        sacrecords4 = c.String(),
                        reledchoice4 = c.String(),
                        Child5FirstName = c.String(),
                        Child5MiddleInitial = c.String(),
                        Child5LastName = c.String(),
                        Child5Grade = c.String(),
                        Child5DOB = c.String(),
                        Child5Email = c.String(),
                        Child5BaptismPlace = c.String(),
                        Child5BaptismDate = c.String(),
                        Child5EucharistPlace = c.String(),
                        Child5EucharistDate = c.String(),
                        sacrecords5 = c.String(),
                        reledchoice5 = c.String(),
                        Child6FirstName = c.String(),
                        Child6MiddleInitial = c.String(),
                        Child6LastName = c.String(),
                        Child6Grade = c.String(),
                        Child6DOB = c.String(),
                        Child6Email = c.String(),
                        Child6BaptismPlace = c.String(),
                        Child6BaptismDate = c.String(),
                        Child6EucharistPlace = c.String(),
                        Child6EucharistDate = c.String(),
                        sacrecords6 = c.String(),
                        reledchoice6 = c.String(),
                        amtdue = c.String(),
                    })
                .PrimaryKey(t => t.ReligiousEdModelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReligiousEdModels");
            DropTable("dbo.FuneralRequestModels");
            DropTable("dbo.FuneralHomeInfoModels");
            DropTable("dbo.BaptismRequestModels");
        }
    }
}
