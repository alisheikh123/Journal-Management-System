namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("couses")]
    public partial class cous
    {
        public int id { get; set; }

        public string cname { get; set; }

        public string cdes { get; set; }

        public string tid { get; set; }

        public string pay { get; set; }

        public string photo { get; set; }

        public string did { get; set; }
    }
}
