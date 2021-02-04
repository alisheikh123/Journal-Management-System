namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblchallantemp")]
    public partial class tblchallantemp
    {
        public int id { get; set; }

        public string appno { get; set; }

        public string regno { get; set; }

        public string date { get; set; }

        public string name { get; set; }

        public string year { get; set; }

        public string program { get; set; }

        public string fee { get; set; }

        public string dtoday { get; set; }
    }
}
