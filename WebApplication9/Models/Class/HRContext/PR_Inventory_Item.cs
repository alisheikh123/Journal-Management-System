namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_Inventory_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR_Inventory_Item()
        {
            PR_InventoryLogs = new HashSet<PR_InventoryLogs>();
            PR_PurchaseOrderItem = new HashSet<PR_PurchaseOrderItem>();
            PR_RequisitionItem = new HashSet<PR_RequisitionItem>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string item_name { get; set; }

        [Required]
        [StringLength(50)]
        public string item_Desc { get; set; }

        public int item_unit { get; set; }

        public int item_type_id { get; set; }

        public int item_category_id { get; set; }

        public int lot_n0 { get; set; }

        public DateTime Date { get; set; }

        public int existing_quantity { get; set; }

        public string activity { get; set; }

        public int? reqtype_id { get; set; }

        public virtual PR_Category PR_Category { get; set; }

        public virtual PR_ReqType PR_ReqType { get; set; }

        public virtual PR_Type PR_Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_InventoryLogs> PR_InventoryLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_PurchaseOrderItem> PR_PurchaseOrderItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_RequisitionItem> PR_RequisitionItem { get; set; }
    }
}
