namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Enrolled_Students
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RegID { get; set; }

        [StringLength(2)]
        public string AdmYear { get; set; }

        [StringLength(1)]
        public string Fall_Spring { get; set; }

        [StringLength(5)]
        public string DepID { get; set; }

        [StringLength(5)]
        public string ProgramID { get; set; }

        public short? Rollno { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rDate { get; set; }

        public string CompleteRollno { get; set; }

        public bool? idcard_status { get; set; }

        [StringLength(50)]
        public string date_card_issued { get; set; }

        [StringLength(50)]
        public string date_card_modified { get; set; }

        public bool? active { get; set; }

        public bool? provisnal { get; set; }
    }
}
