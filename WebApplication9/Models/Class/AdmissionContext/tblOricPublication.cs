namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOricPublication")]
    public partial class tblOricPublication
    {
        public int id { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string journal { get; set; }

        [Required]
        public string year { get; set; }

        [Required]
        public string reference { get; set; }

        public int? dept_id { get; set; }
    }
}
