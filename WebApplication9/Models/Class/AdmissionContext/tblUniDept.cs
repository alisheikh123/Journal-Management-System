namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUniDept")]
    public partial class tblUniDept
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}
