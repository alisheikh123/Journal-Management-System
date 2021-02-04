namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SliderData")]
    public partial class SliderData
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string SlideText { get; set; }

        [Required]
        public string Images { get; set; }
    }
}
