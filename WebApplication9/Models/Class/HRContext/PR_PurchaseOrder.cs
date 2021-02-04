namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR_PurchaseOrder()
        {
            PR_PurchaseOrderItem = new HashSet<PR_PurchaseOrderItem>();
            PR_PurchaseOrderLogs = new HashSet<PR_PurchaseOrderLogs>();
        }

        public int id { get; set; }

        public DateTime? date_created { get; set; }

        [Required]
        public string expected_date { get; set; }

        [Required]
        public string desc { get; set; }

        public long? req_id { get; set; }

        public int num_of_items { get; set; }

        public string activity { get; set; }

        public int emp_id { get; set; }

        public int status_id { get; set; }

        public float total_amount { get; set; }

        public DateTime status_change_time { get; set; }

        public virtual PR_ReqStatus PR_ReqStatus { get; set; }

        public virtual PR_Requisition PR_Requisition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_PurchaseOrderItem> PR_PurchaseOrderItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_PurchaseOrderLogs> PR_PurchaseOrderLogs { get; set; }
    }
}
