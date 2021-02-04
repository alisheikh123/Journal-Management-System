namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tmptbl_Enroll
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string RegID { get; set; }

        [StringLength(2)]
        public string aYear { get; set; }

        [StringLength(1)]
        public string FallSprg { get; set; }

        [StringLength(5)]
        public string DepID { get; set; }

        [StringLength(5)]
        public string SubDepID { get; set; }

        [StringLength(5)]
        public string ProgramID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rollnum { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime rDate { get; set; }
    }
}
