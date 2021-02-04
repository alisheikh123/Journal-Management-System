namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_Requisition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PR_Requisition()
        {
            PR_PurchaseOrder = new HashSet<PR_PurchaseOrder>();
            PR_PurchaseOrderLogs = new HashSet<PR_PurchaseOrderLogs>();
            PR_ReqStatusLog = new HashSet<PR_ReqStatusLog>();
            PR_RequisitionItem = new HashSet<PR_RequisitionItem>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Required]
        public string req_date { get; set; }

        public string apply_date { get; set; }

        public string priority { get; set; }

        public int emp_id { get; set; }

        public int reqtype_id { get; set; }

        public int reporting_person { get; set; }

        public int previous_reporting_person { get; set; }

        public int dept_id { get; set; }

        public int status_id { get; set; }

        public DateTime status_change_time { get; set; }

        public int no_of_items { get; set; }

        public string activity { get; set; }

        public int alert_limit { get; set; }

        public int times { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_PurchaseOrder> PR_PurchaseOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_PurchaseOrderLogs> PR_PurchaseOrderLogs { get; set; }

        public virtual PR_ReqStatus PR_ReqStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_ReqStatusLog> PR_ReqStatusLog { get; set; }

        public virtual PR_ReqType PR_ReqType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PR_RequisitionItem> PR_RequisitionItem { get; set; }
    }
}
