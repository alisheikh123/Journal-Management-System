namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblchangedept")]
    public partial class tblchangedept
    {
        public int id { get; set; }

        public string sturegno { get; set; }

        public string dept { get; set; }

        public string procode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }
    }
}
