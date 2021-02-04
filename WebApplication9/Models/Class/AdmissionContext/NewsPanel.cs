namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsPanel")]
    public partial class NewsPanel
    {
        public int ID { get; set; }

        public string NewsMarque { get; set; }

        [Required]
        public string NewsHeadLines { get; set; }

        public string Img { get; set; }
    }
}
