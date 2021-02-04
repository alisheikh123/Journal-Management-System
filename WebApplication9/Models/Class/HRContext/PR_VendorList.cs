namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_VendorList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR_VendorList()
        {
            PR_InventoryLogs = new HashSet<PR_InventoryLogs>();
            PR_PurchaseOrderItem = new HashSet<PR_PurchaseOrderItem>();
            PR_VendorLogs = new HashSet<PR_VendorLogs>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string company_name { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(35)]
        public string streetAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string company_desc { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        public string contact { get; set; }

        [StringLength(20)]
        public string contact_name { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public string usage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_InventoryLogs> PR_InventoryLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_PurchaseOrderItem> PR_PurchaseOrderItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_VendorLogs> PR_VendorLogs { get; set; }
    }
}
