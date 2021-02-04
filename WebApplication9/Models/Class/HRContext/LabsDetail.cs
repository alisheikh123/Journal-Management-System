namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LabsDetail")]
    public partial class LabsDetail
    {
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public string Short_Desc { get; set; }

        [Required]
        public string Long_Desc { get; set; }

        public string Type { get; set; }

        public string Heading { get; set; }
    }
}
