namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOricResearchProjectsHead")]
    public partial class tblOricResearchProjectsHead
    {
        public int id { get; set; }

        [Required]
        public string projectHeadName { get; set; }
    }
}
