namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOricSlider")]
    public partial class tblOricSlider
    {
        public int id { get; set; }

        [Required]
        public string sliderText { get; set; }

        [Required]
        public string sliderImagePath { get; set; }
    }
}
