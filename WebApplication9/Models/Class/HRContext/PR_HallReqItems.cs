namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_HallReqItems
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string desc { get; set; }

        public int? quantity { get; set; }

        public float? price { get; set; }

        public float amount { get; set; }

        public long hallReq_id { get; set; }

        public virtual PR_HallReq PR_HallReq { get; set; }
    }
}
