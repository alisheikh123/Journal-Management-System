namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAdmin")]
    public partial class tblAdmin
    {
        public int id { get; set; }

        public string Email { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public int? designation { get; set; }

        public string description { get; set; }

        public int? rights { get; set; }
    }
}
