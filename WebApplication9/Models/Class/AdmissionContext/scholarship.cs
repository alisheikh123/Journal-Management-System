namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("scholarship")]
    public partial class scholarship
    {
        public int id { get; set; }

        public string title { get; set; }

        public string value { get; set; }

        public string link { get; set; }

        public string category { get; set; }

        [Column(TypeName = "date")]
        public DateTime? deadline { get; set; }
    }
}
