namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsSite")]
    public partial class NewsSite
    {
        public int ID { get; set; }

        public string NewsMarque { get; set; }

        public string NewsHeadLines { get; set; }
    }
}
