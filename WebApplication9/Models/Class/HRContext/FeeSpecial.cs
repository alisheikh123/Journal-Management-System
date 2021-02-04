namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeeSpecial")]
    public partial class FeeSpecial
    {
        [Key]
        [StringLength(5)]
        public string FCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(15)]
        public string FeeType { get; set; }

        [StringLength(10)]
        public string Degree { get; set; }

        public double Amount { get; set; }

        public string Admission_Fee { get; set; }

        public string Registration_Fee { get; set; }

        public string Library_Security { get; set; }
    }
}
