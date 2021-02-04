namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDiscountApplied")]
    public partial class tblDiscountApplied
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long studentregno { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int semester { get; set; }

        public int? discounttypeid { get; set; }

        public string discountpercent { get; set; }

        public virtual tblDiscountType tblDiscountType { get; set; }

        public virtual tblDiscountType tblDiscountType1 { get; set; }
    }
}
