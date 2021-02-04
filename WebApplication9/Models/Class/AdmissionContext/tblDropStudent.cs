namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDropStudent")]
    public partial class tblDropStudent
    {
        public int id { get; set; }

        public string StuRegNo { get; set; }

        public string DepID { get; set; }

        public string ProgramID { get; set; }

        public string RollNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dropDate { get; set; }

        public bool? status_Stuck { get; set; }

        public bool? status_Refund { get; set; }

        public string reason { get; set; }
    }
}
