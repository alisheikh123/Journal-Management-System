namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblsocietymember
    {
        public int id { get; set; }

        public string fname { get; set; }

        public string email { get; set; }

        public string roll_no { get; set; }

        public int? program_id { get; set; }

        public int? semester { get; set; }

        public int? existing_society { get; set; }

        public int? society_id { get; set; }
    }
}
