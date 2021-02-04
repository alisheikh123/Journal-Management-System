namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Certification
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string CertificationName { get; set; }

        public string Description { get; set; }

        public string filePath { get; set; }
    }
}
