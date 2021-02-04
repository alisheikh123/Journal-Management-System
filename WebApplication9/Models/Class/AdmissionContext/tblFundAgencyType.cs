namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFundAgencyType")]
    public partial class tblFundAgencyType
    {
        public int id { get; set; }

        public string FundAgencyType { get; set; }
    }
}
