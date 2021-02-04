namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_ReturnLogs
    {
        public int id { get; set; }

        public int? student { get; set; }

        public int art_cat { get; set; }

        public string title { get; set; }

        public string isbn { get; set; }

        public string author { get; set; }

        public string Status { get; set; }

        public DateTime? returnedDate { get; set; }
    }
}
