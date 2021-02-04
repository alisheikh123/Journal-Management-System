namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOricModalPopup")]
    public partial class tblOricModalPopup
    {
        public int id { get; set; }

        [Required]
        public string modalHeader { get; set; }

        [Required]
        public string modalDetail { get; set; }

        [Required]
        public string modalImagePath { get; set; }
    }
}
