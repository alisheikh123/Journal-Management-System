namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_AlliedLogs
    {
        public long id { get; set; }

        public int Catid { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string activity { get; set; }

        public float cost { get; set; }

        public string category { get; set; }

        public string Status { get; set; }

        public int quantity { get; set; }

        public int remaining_quan { get; set; }

        public DateTime? date { get; set; }
    }
}
