namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdmissionCounter")]
    public partial class AdmissionCounter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Admission { get; set; }

        [Required]
        [StringLength(50)]
        public string Fall { get; set; }

        [Required]
        [StringLength(50)]
        public string DeadLine { get; set; }

        [Required]
        [StringLength(20)]
        public string Counter { get; set; }
    }
}
