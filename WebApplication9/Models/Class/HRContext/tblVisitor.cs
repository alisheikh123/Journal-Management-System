namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblVisitor")]
    public partial class tblVisitor
    {
        [Key]
        public int visitor_Id { get; set; }

        public int? visitor_No { get; set; }

        public string visitor_Code { get; set; }

        public string visitor_Name { get; set; }

        public string visitor_CNIC { get; set; }

        [StringLength(50)]
        public string visitor_Mobile { get; set; }

        public DateTime? dateAdd { get; set; }

        [Column(TypeName = "image")]
        public byte[] visitor_Image { get; set; }

        public string purpose { get; set; }

        public string meetWith { get; set; }
    }
}
