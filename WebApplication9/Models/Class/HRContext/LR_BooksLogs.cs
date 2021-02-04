namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_BooksLogs
    {
        public long id { get; set; }

        public string ISBN { get; set; }

        public string name { get; set; }

        public float cost { get; set; }

        public string category { get; set; }

        public string Status { get; set; }

        public DateTime? date { get; set; }

        public int bookid { get; set; }
    }
}
