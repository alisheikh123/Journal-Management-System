namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_Accounts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMS_Accounts()
        {
            IMS_PurchaseOrder = new HashSet<IMS_PurchaseOrder>();
            IMS_VendorItemCategory = new HashSet<IMS_VendorItemCategory>();
            IMS_VendorItemRate = new HashSet<IMS_VendorItemRate>();
        }

        public int Id { get; set; }

        public int AccountNo { get; set; }

        public string AccountCode { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountTitle { get; set; }

        public string PhoneNo { get; set; }

        [Required]
        public string MobileNo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(35)]
        public string Address { get; set; }

        public string NTN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_PurchaseOrder> IMS_PurchaseOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_VendorItemCategory> IMS_VendorItemCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_VendorItemRate> IMS_VendorItemRate { get; set; }
    }
}
