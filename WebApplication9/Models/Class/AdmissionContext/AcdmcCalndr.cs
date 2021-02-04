namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AcdmcCalndr")]
    public partial class AcdmcCalndr
    {
        public int Id { get; set; }

        [Required]
        public string Img { get; set; }
    }
}
