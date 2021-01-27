namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changemodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblJournals", "Noofauthor", c => c.Int(nullable: false));
            AddColumn("dbo.tblJournals", "author1", c => c.String(nullable: false));
            AddColumn("dbo.tblJournals", "author2", c => c.String());
            AddColumn("dbo.tblJournals", "author3", c => c.String());
            AddColumn("dbo.tblJournals", "author4", c => c.String());
            AddColumn("dbo.tblJournals", "author5", c => c.String());
            AddColumn("dbo.tblJournals", "author6", c => c.String());
            AddColumn("dbo.tblJournals", "issueno", c => c.Int(nullable: false));
            AlterColumn("dbo.tblJournals", "Impact_Factor", c => c.String());
            DropColumn("dbo.tblJournals", "author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblJournals", "author", c => c.String(nullable: false));
            AlterColumn("dbo.tblJournals", "Impact_Factor", c => c.String(nullable: false));
            DropColumn("dbo.tblJournals", "issueno");
            DropColumn("dbo.tblJournals", "author6");
            DropColumn("dbo.tblJournals", "author5");
            DropColumn("dbo.tblJournals", "author4");
            DropColumn("dbo.tblJournals", "author3");
            DropColumn("dbo.tblJournals", "author2");
            DropColumn("dbo.tblJournals", "author1");
            DropColumn("dbo.tblJournals", "Noofauthor");
        }
    }
}
