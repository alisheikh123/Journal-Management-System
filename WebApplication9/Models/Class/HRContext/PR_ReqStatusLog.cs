namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_ReqStatusLog
    {
        public long id { get; set; }

        public long req_id { get; set; }

        public string req_date { get; set; }

        public string apply_date { get; set; }

        public int emp_id { get; set; }

        public int? reqtype_id { get; set; }

        public int status_set_by { get; set; }

        public string status { get; set; }

        public DateTime status_change_time { get; set; }

        public int no_of_items { get; set; }

        public string activity { get; set; }

        public int? dept_Id { get; set; }

        public virtual PR_ReqType PR_ReqType { get; set; }

        public virtual PR_Requisition PR_Requisition { get; set; }
    }
}
