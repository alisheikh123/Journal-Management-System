namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSubDept")]
    public partial class tblSubDept
    {
        public int Id { get; set; }

        public string Deptt_Code { get; set; }

        public string Deptt_Name { get; set; }

        [Required]
        public string Fac_Code { get; set; }
    }
}
