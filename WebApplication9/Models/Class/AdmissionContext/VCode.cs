namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VCode
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string VEmail { get; set; }

        [Column("VCode")]
        [Required]
        [StringLength(50)]
        public string VCode1 { get; set; }
    }
}
