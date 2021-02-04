namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("checkDB")]
    public partial class checkDB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string email { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string pass { get; set; }
    }
}
