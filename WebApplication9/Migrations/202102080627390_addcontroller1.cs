namespace WebApplication9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcontroller1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblOricResearchProjects",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        projectName = c.String(nullable: false),
                        projectHeadId = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tblOricResearchProjectsHead",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        projectHeadName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblOricResearchProjectsHead");
            DropTable("dbo.tblOricResearchProjects");
        }
    }
}
