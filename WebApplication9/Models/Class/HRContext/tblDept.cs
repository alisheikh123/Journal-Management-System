namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDept")]
    public partial class tblDept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string Dept { get; set; }

        public string DeptCode { get; set; }

        public string fac_ID { get; set; }

        public string Des { get; set; }

        public string image { get; set; }

        public string nname { get; set; }
    }
}
