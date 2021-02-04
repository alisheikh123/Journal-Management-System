namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Due
    {
        public int id { get; set; }

        public string Outstanding_dues { get; set; }

        public string Previoues_blance { get; set; }

        public bool? status { get; set; }

        public string Date { get; set; }

        public string StuRegNo { get; set; }

        public string PayType { get; set; }

        public int? Semester { get; set; }

        public string Bank_date { get; set; }

        public string accid { get; set; }
    }
}
