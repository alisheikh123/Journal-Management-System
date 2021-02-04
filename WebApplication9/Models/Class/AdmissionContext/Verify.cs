namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Verify")]
    public partial class Verify
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string VCodes { get; set; }
    }
}
