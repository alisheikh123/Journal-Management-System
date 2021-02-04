namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAdmissionsFee")]
    public partial class tblAdmissionsFee
    {
        public int id { get; set; }

        public string Fac_ID { get; set; }

        public string DepId { get; set; }

        public string SubDepId { get; set; }

        public string ProgramId { get; set; }

        public string Semester { get; set; }

        public short? CreditHours { get; set; }

        public double? FeePerCH { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? TotalFee { get; set; }

        public double? Admissions_Fee { get; set; }

        public double? Library_Fee { get; set; }

        public double? Registration_Fee { get; set; }

        public double? Verification_Fee { get; set; }

        public double? University_Card_Fee { get; set; }

        public double? Examination_Fee { get; set; }

        public double? IT_Services_Fee { get; set; }
    }
}
