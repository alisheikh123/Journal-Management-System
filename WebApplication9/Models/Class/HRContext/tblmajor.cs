namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblmajor")]
    public partial class tblmajor
    {
        public int id { get; set; }

        public string major { get; set; }

        public int degreeType_id { get; set; }
    }
}
