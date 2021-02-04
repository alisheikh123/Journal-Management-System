namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblprogramsdetail")]
    public partial class tblprogramsdetail
    {
        public int id { get; set; }

        public string Introduction { get; set; }

        public string ProgramDescription { get; set; }

        public string MissionStatement { get; set; }

        public string ProgramObjectives { get; set; }

        public string CarrierOpportunities { get; set; }

        public string Criteria { get; set; }

        public string Image { get; set; }

        public string Vission { get; set; }

        public string CourseImages { get; set; }

        public string Fac_ID { get; set; }

        public string Dep_ID { get; set; }

        public string Prog_ID { get; set; }

        public string featureImage { get; set; }
    }
}
