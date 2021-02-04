namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDiscountType")]
    public partial class tblDiscountType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDiscountType()
        {
            tblDiscountApplieds = new HashSet<tblDiscountApplied>();
            tblDiscountApplieds1 = new HashSet<tblDiscountApplied>();
        }

        [Key]
        public int categoryid { get; set; }

        [StringLength(50)]
        public string categoryname { get; set; }

        [StringLength(50)]
        public string discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDiscountApplied> tblDiscountApplieds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDiscountApplied> tblDiscountApplieds1 { get; set; }
    }
}
