namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFundAgency")]
    public partial class tblFundAgency
    {
        public int id { get; set; }

        public int fundAgencyType_id { get; set; }

        [Required]
        public string FundAgency { get; set; }

        public string fundAgency_Link { get; set; }

        public string Title { get; set; }

        public string Worth { get; set; }

        public DateTime? Date { get; set; }
    }
}
