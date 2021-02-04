namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_BookCategoryLogs
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        public string name { get; set; }

        public int parent { get; set; }

        public string Activity { get; set; }

        public int cat_id { get; set; }
    }
}
