namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SelectedStudent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RegID { get; set; }

        [StringLength(5)]
        public string DepID { get; set; }

        [StringLength(5)]
        public string ProgramID { get; set; }

        public bool? AdmFeePaid { get; set; }
    }
}
