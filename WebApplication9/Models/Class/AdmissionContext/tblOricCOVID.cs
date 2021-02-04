namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOricCOVID")]
    public partial class tblOricCOVID
    {
        public int id { get; set; }

        [Required]
        public string covidHeader { get; set; }

        [Required]
        public string covidDetail { get; set; }

        [Required]
        public string covidImagePath { get; set; }
    }
}
