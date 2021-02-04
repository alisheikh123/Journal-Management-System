namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDiscretAdm")]
    public partial class tblDiscretAdm
    {
        public int id { get; set; }

        public long studentReg_id { get; set; }

        public DateTime date_given { get; set; }

        public string GivenByEmp { get; set; }
    }
}
