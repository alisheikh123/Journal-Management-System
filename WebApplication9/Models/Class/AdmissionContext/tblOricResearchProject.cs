namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblOricResearchProject
    {
        public int id { get; set; }

        [Required]
        public string projectName { get; set; }

        public int? projectHeadId { get; set; }
    }
}
