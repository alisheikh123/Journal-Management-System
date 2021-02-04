namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeeSpecials")]
    public partial class FeeSpecial1
    {
        [Key]
        public string FCode { get; set; }

        public string Description { get; set; }

        public string FeeType { get; set; }

        public string Degree { get; set; }

        public double Amount { get; set; }

        public string Admission_Fee { get; set; }

        public string Registration_Fee { get; set; }

        public string Library_Security { get; set; }

        public int? Semester { get; set; }
    }
}
