namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_ReservationLogs
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        public int art_id { get; set; }

        public int? student { get; set; }

        public string isbn { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string activity { get; set; }
    }
}
