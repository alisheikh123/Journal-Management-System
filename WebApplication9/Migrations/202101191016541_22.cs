namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _22 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblJournals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false),
                        title = c.String(nullable: false),
                        author = c.String(nullable: false),
                        journalName = c.String(nullable: false),
                        volumeno = c.String(nullable: false),
                        SPage = c.Int(nullable: false),
                        EPage = c.Int(nullable: false),
                        totalPage = c.Int(nullable: false),
                        pubName = c.String(nullable: false),
                        Impact_Factor = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        pubDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblJournals");
        }
    }
}
