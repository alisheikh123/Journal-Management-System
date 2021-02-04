namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("signup")]
    public partial class signup
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
