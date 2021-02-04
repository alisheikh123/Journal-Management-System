namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_ReIssue_Records
    {
        public int id { get; set; }

        public int? student_id { get; set; }

        public string ISBN { get; set; }

        public string author_name { get; set; }

        public int fine { get; set; }

        public DateTime? date { get; set; }

        public DateTime ReIssue_Date { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Status { get; set; }

        public string title { get; set; }

        public string activity { get; set; }

        public int artCat_id { get; set; }

        public virtual LR_ArticleCategory LR_ArticleCategory { get; set; }
    }
}
