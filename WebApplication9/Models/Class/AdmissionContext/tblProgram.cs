namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblProgram
    {
        public int id { get; set; }

        public string proName { get; set; }

        public string fac_ID { get; set; }

        [StringLength(50)]
        public string proType { get; set; }

        public string proTypeExt { get; set; }

        [Required]
        [StringLength(5)]
        public string dept_id { get; set; }

        [StringLength(5)]
        public string proCode { get; set; }

        public double? years { get; set; }

        public double? fee { get; set; }

        public double? tuition_fee { get; set; }

        public string ProgFeeCode { get; set; }

        public string hod { get; set; }

        [StringLength(50)]
        public string activity { get; set; }
    }
}
