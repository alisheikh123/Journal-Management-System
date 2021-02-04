namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UOGStudent
    {
        public int id { get; set; }

        [StringLength(50)]
        public string regno { get; set; }

        public string rollno { get; set; }

        public string name { get; set; }

        public string father_name { get; set; }

        public string dept_name { get; set; }

        [StringLength(50)]
        public string year { get; set; }
    }
}
