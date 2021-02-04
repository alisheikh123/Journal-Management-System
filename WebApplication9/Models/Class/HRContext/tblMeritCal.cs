namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMeritCal")]
    public partial class tblMeritCal
    {
        public int id { get; set; }

        public long studentReg_id { get; set; }

        public int program_id { get; set; }

        public decimal TotalMarks { get; set; }

        public decimal MarksObtained { get; set; }

        public decimal InterviewMarks { get; set; }

        public string UploadedByEmp { get; set; }

        public DateTime DateUploaded { get; set; }

        public decimal CourseMarks { get; set; }

        public decimal FinalMarks { get; set; }
    }
}
