namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblfreezStudent")]
    public partial class tblfreezStudent
    {
        public int id { get; set; }

        public string StuRegNo { get; set; }

        public string DepID { get; set; }

        public string ProgramID { get; set; }

        public string RollNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dDate { get; set; }

        public string Semester { get; set; }
    }
}
