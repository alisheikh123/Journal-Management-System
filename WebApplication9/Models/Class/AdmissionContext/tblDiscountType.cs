namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDiscountType")]
    public partial class tblDiscountType
    {
        [Key]
        public int categoryid { get; set; }

        [StringLength(50)]
        public string categoryname { get; set; }

        [StringLength(50)]
        public string discount { get; set; }
    }
}
