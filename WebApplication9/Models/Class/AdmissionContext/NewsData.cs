namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsData")]
    public partial class NewsData
    {
        public int ID { get; set; }

        [Required]
        public string NewsMarque { get; set; }

        [Required]
        public string NewsHeadLines { get; set; }

        [Required]
        public string Img { get; set; }
    }
}
