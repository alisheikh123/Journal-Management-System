namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_Alerts
    {
        public int id { get; set; }

        public int article_id { get; set; }

        public int article_type { get; set; }

        public int alert_limit { get; set; }

        public int alerted_employee { get; set; }

        public string alert_date { get; set; }
    }
}
