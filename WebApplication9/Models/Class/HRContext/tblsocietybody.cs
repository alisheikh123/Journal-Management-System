namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblsocietybody")]
    public partial class tblsocietybody
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string email { get; set; }

        public int? society_id { get; set; }
    }
}
