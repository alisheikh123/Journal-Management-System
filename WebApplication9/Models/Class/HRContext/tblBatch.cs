namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBatch")]
    public partial class tblBatch
    {
        public int id { get; set; }

        public string batch { get; set; }

        public int code { get; set; }

        public int BatchType { get; set; }
    }
}
