namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("abc")]
    public partial class abc
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public byte[] name { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
}
