namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Enrolled_Studentsss
    {
        public int Id { get; set; }

        public long RegID { get; set; }

        public string AdmYear { get; set; }

        public string Fall_Spring { get; set; }

        public int? dept_id { get; set; }

        public int? program_id { get; set; }

        public short? Rollno { get; set; }

        public DateTime? rDate { get; set; }

        public string CompleteRollno { get; set; }

        public bool? idcard_status { get; set; }

        public string date_card_issued { get; set; }

        public string date_card_modified { get; set; }

        public bool? active { get; set; }

        public int? batch_id { get; set; }
    }
}
