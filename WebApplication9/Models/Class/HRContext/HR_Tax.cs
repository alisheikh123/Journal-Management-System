namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Tax
    {
        [Key]
        public int tax_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string taxName { get; set; }

        public decimal taxPercentage { get; set; }
    }
}
