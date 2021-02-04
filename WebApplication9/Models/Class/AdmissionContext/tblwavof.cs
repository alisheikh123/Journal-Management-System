namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblwavof")]
    public partial class tblwavof
    {
        public int id { get; set; }

        public string Semester { get; set; }

        public bool? Admission_Fee { get; set; }

        public bool? Registration_Fee { get; set; }

        public bool? Library_Security_Fee { get; set; }

        public bool? Societies_and_Club_Fee { get; set; }

        public bool? Examination_Fee { get; set; }

        public bool? Enrollment_Fee { get; set; }

        public string StuRegNo { get; set; }

        public string accid { get; set; }
    }
}
