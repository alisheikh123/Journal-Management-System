namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cover")]
    public partial class cover
    {
        public int id { get; set; }

        public string head1 { get; set; }

        public string head2 { get; set; }

        public string url { get; set; }
    }
}
