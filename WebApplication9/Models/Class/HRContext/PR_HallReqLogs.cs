namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_HallReqLogs
    {
        public long id { get; set; }

        public long req_id { get; set; }

        public int emp_id { get; set; }

        public int status_set_by { get; set; }

        public string status { get; set; }

        public DateTime status_change_time { get; set; }

        public string activity { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }

        public virtual PR_HallReq PR_HallReq { get; set; }
    }
}
