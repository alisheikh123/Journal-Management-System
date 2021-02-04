namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_BookCategory
    {
        public int id { get; set; }

        public int book_id { get; set; }

        public int category_id { get; set; }

        public DateTime? date { get; set; }

        public string Activity { get; set; }

        public virtual LR_Category LR_Category { get; set; }
    }
}
