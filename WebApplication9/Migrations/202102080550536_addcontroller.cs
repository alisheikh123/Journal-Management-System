namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcontroller : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.scholarship",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        value = c.String(),
                        link = c.String(),
                        category = c.String(),
                        deadline = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SliderImgs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Images = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.tblActivitySheet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        activityDate = c.DateTime(nullable: false),
                        activityHead = c.String(nullable: false),
                        activitySubHead = c.String(),
                        activityDetail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblDetails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false),
                        uploadImage = c.String(nullable: false),
                        heading = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblforumcenter",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        upload_Image = c.String(),
                        heading = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblFundAgency",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fundAgencyType_id = c.Int(nullable: false),
                        FundAgency = c.String(nullable: false),
                        fundAgency_Link = c.String(),
                        Title = c.String(),
                        Worth = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblFundAgencyType",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FundAgencyType = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblOricCOVID",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        covidHeader = c.String(nullable: false),
                        covidDetail = c.String(nullable: false),
                        covidImagePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblOricEvents",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        eventDate = c.DateTime(nullable: false),
                        eventDetail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblOricModalPopup",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        modalHeader = c.String(nullable: false),
                        modalDetail = c.String(nullable: false),
                        modalImagePath = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblOricMou",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MouDate = c.DateTime(nullable: false),
                        MouDetail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblOricPublication",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        author = c.String(nullable: false),
                        title = c.String(nullable: false),
                        journal = c.String(nullable: false),
                        year = c.String(nullable: false),
                        reference = c.String(nullable: false),
                        dept_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblOricPublication");
            DropTable("dbo.tblOricMou");
            DropTable("dbo.tblOricModalPopup");
            DropTable("dbo.tblOricEvents");
            DropTable("dbo.tblOricCOVID");
            DropTable("dbo.tblFundAgencyType");
            DropTable("dbo.tblFundAgency");
            DropTable("dbo.tblforumcenter");
            DropTable("dbo.tblDetails");
            DropTable("dbo.tblActivitySheet");
            DropTable("dbo.SliderImgs");
            DropTable("dbo.scholarship");
        }
    }
}
