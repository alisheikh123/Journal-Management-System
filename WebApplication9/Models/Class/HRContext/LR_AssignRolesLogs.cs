namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_AssignRolesLogs
    {
        public int id { get; set; }

        public int roleid { get; set; }

        public int user { get; set; }

        public int category { get; set; }

        public int priority { get; set; }

        public string Activity { get; set; }

        public DateTime? date { get; set; }
    }
}
