namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_PurchaseOrderLogs
    {
        public long id { get; set; }

        public int POrder_id { get; set; }

        public int emp_id { get; set; }

        public int status_set_by { get; set; }

        public string status { get; set; }

        public DateTime? status_change_time { get; set; }

        public DateTime? date_created { get; set; }

        [Required]
        public string expected_date { get; set; }

        public long? req_id { get; set; }

        public int num_of_items { get; set; }

        public string activity { get; set; }

        public float total_amount { get; set; }

        public virtual PR_PurchaseOrder PR_PurchaseOrder { get; set; }

        public virtual PR_Requisition PR_Requisition { get; set; }
    }
}
