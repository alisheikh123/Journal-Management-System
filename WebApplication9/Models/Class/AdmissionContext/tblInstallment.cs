namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblInstallment")]
    public partial class tblInstallment
    {
        public int id { get; set; }

        public string regno { get; set; }

        public string totalfee { get; set; }

        public string installfee { get; set; }

        public string duedate { get; set; }

        public bool? status { get; set; }

        public string semester { get; set; }

        public string installno { get; set; }

        public string dues { get; set; }

        public string bank_date { get; set; }

        public string accid { get; set; }
    }
}
