namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Outline")]
    public partial class Outline
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string OutlineName { get; set; }

        [Required]
        [StringLength(50)]
        public string Path { get; set; }

        [Required]
        [StringLength(50)]
        public string Dept { get; set; }
    }
}
