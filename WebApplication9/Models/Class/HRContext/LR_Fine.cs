namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_Fine
    {
        [Key]
        public int fineId { get; set; }

        public decimal fine { get; set; }

        public int dayLimit { get; set; }
    }
}
