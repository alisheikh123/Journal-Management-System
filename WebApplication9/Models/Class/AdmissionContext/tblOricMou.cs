namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOricMou")]
    public partial class tblOricMou
    {
        public int id { get; set; }

        public DateTime MouDate { get; set; }

        [Required]
        public string MouDetail { get; set; }
    }
}
