namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbldiscountLog")]
    public partial class tbldiscountLog
    {
        public int id { get; set; }

        public string sturegno { get; set; }

        public string discount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public string accountid { get; set; }

        public string semester { get; set; }

        public string discountper { get; set; }
    }
}
