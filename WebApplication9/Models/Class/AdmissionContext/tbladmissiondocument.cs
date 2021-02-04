namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbladmissiondocument
    {
        public int id { get; set; }

        public string StuRegNo { get; set; }

        public bool? cnic { get; set; }

        public bool? Matric_OLevel { get; set; }

        public bool? BS_MA { get; set; }

        public bool? FA_ALevel { get; set; }

        public bool? BA { get; set; }

        public bool? Bank_Challan { get; set; }

        public bool? Photo { get; set; }

        public bool? Father_Income_Certicate { get; set; }

        public bool? Character_Certicate { get; set; }
    }
}
