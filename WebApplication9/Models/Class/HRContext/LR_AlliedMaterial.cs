namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_AlliedMaterial
    {
        public int id { get; set; }

        public int artCat_id { get; set; }

        [Required]
        public string title { get; set; }

        public int Volume_No { get; set; }

        public int Issue_No { get; set; }

        [Required]
        [StringLength(35)]
        public string publisher_name { get; set; }

        public string thesis_category { get; set; }

        public string description { get; set; }

        public DateTime? purchase_date { get; set; }

        public int cost { get; set; }

        [Required]
        [StringLength(35)]
        public string author_name { get; set; }

        public int Quantity { get; set; }

        public DateTime? publication_date { get; set; }

        public string Pamphlet_Category { get; set; }

        public string Novel_category { get; set; }

        public string CD_category { get; set; }

        public string Reports_category { get; set; }

        public string status { get; set; }

        public string category { get; set; }

        public DateTime? date { get; set; }

        public string activity { get; set; }

        public int Remaining_Quanity { get; set; }

        public virtual LR_ArticleCategory LR_ArticleCategory { get; set; }
    }
}
