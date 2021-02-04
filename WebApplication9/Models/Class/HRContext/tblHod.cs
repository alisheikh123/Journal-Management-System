namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHod")]
    public partial class tblHod
    {
        public int id { get; set; }

        public string name { get; set; }

        public string facID { get; set; }

        public string uName { get; set; }

        public string password { get; set; }
    }
}
