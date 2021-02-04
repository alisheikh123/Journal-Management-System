namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblFac_qualification
    {
        [Key]
        [Column(Order = 0)]
        public int qualification_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fac_Id { get; set; }

        public string qualification_name { get; set; }

        public string institute { get; set; }
    }
}
