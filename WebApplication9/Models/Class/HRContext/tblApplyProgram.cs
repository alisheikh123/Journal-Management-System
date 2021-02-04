namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblApplyProgram
    {
        public int id { get; set; }

        public string applicationNo { get; set; }

        public int? priority { get; set; }

        [Column(TypeName = "date")]
        public DateTime? applicationDate { get; set; }

        [StringLength(5)]
        public string departmentID { get; set; }

        [StringLength(5)]
        public string programID { get; set; }

        public string studentRegNo { get; set; }

        public bool? admkitstatus { get; set; }

        public bool? Unselected { get; set; }

        public bool? SemiSelected { get; set; }

        public bool? feestatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public bool? Selected { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateSelected { get; set; }

        public bool? Final { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateFinal { get; set; }

        public byte? Semester { get; set; }
    }
}
