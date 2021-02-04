namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_ReturnBook
    {
        public int id { get; set; }

        public DateTime returnedDate { get; set; }

        public string status { get; set; }

        public int student_id { get; set; }

        public string Department { get; set; }

        public string book_title { get; set; }

        public string ISBN { get; set; }

        public DateTime Issue_Date { get; set; }

        public DateTime DueDate { get; set; }

        public decimal? fine { get; set; }

        public int artCat_id { get; set; }

        public string author_name { get; set; }

        public string activity { get; set; }

        public virtual LR_ArticleCategory LR_ArticleCategory { get; set; }
    }
}
