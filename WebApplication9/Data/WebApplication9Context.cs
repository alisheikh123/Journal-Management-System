using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication9.Data
{
    public class WebApplication9Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication9Context() : base("name=WebApplication9Context")
        {
        }

        public System.Data.Entity.DbSet<WebApplication9.Models.tblJournal> tblJournals { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblActivitySheet> tblActivitySheets { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblDetail> tblDetails { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblforumcenter> tblforumcenters { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricEvent> tblOricEvents { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricModalPopup> tblOricModalPopups { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricMou> tblOricMous { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricPublication> tblOricPublications { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.scholarship> scholarships { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.SliderImg> SliderImgs { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblFundAgency> tblFundAgencies { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblFundAgencyType> tblFundAgencyTypes { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricCOVID> tblOricCOVIDs { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricResearchProject> tblOricResearchProjects { get; set; }

        public System.Data.Entity.DbSet<WebApplication9.Models.Class.AdmissionContext.tblOricResearchProjectsHead> tblOricResearchProjectsHeads { get; set; }
    }
}
