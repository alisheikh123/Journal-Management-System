namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProgramsChangingHistory")]
    public partial class ProgramsChangingHistory
    {
        [Key]
        public int TransID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TransDate { get; set; }

        [Required]
        [StringLength(50)]
        public string RegID { get; set; }

        [StringLength(10)]
        public string Old_Prog { get; set; }

        [StringLength(10)]
        public string New_Prog { get; set; }
    }
}
