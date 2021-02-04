namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("coursedetail")]
    public partial class coursedetail
    {
        public int id { get; set; }

        public string cid { get; set; }

        public string cdetail { get; set; }

        public string title { get; set; }

        public string require { get; set; }

        public string Duration { get; set; }
    }
}
