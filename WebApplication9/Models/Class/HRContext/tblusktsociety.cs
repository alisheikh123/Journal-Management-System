namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblusktsociety
    {
        public int id { get; set; }

        public string society_name { get; set; }

        public string description { get; set; }

        public string org_body_head { get; set; }

        public string date_created { get; set; }

        public int? events { get; set; }
    }
}
