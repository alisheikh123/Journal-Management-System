namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("indexpage")]
    public partial class indexpage
    {
        [Key]
        [StringLength(50)]
        public string email { get; set; }
    }
}
