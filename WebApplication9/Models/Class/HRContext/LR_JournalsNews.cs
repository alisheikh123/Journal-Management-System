namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_JournalsNews
    {
        public int id { get; set; }

        public string name { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [Required]
        [StringLength(30)]
        public string author_name { get; set; }

        [Required]
        [StringLength(30)]
        public string publisher_name { get; set; }

        public float cost { get; set; }

        public DateTime purchase_date { get; set; }

        public DateTime? date { get; set; }

        public string activity { get; set; }

        public DateTime date_year_ofpublication { get; set; }

        public float edition { get; set; }

        public decimal Impact_Factor { get; set; }

        public decimal Eigen_Factor { get; set; }

        public int Bill_num { get; set; }

        public string status { get; set; }

        public string article_category { get; set; }

        public string type_category { get; set; }

        public int artCat_id { get; set; }

        public int Quantity { get; set; }

        public string Company { get; set; }

        public string Language { get; set; }

        public int Remaining_Quanity { get; set; }

        public virtual LR_ArticleCategory LR_ArticleCategory { get; set; }
    }
}
