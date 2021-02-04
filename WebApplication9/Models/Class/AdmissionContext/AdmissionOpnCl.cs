namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdmissionOpnCl
    {
        public int Id { get; set; }

        [Required]
        public string Admission { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
