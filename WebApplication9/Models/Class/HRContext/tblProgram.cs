namespace WebApplication9.Models.Class.HRContext
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

        public string proType { get; set; }

        public string proTypeExt { get; set; }

        public string dept_id { get; set; }

        public string proCode { get; set; }

        public double? years { get; set; }

        public double? fee { get; set; }

        public double? tuition_fee { get; set; }

        public string ProgFeeCode { get; set; }

        public string hod { get; set; }

        public string activity { get; set; }

        public int? parent_id { get; set; }

        public int? grandparent_id { get; set; }

        public int? batch_id { get; set; }

        public virtual tblDept1 tblDept { get; set; }

        public virtual tblSubDept tblSubDept { get; set; }
    }
}
