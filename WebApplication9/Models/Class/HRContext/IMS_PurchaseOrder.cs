namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMS_PurchaseOrder()
        {
            IMS_PurchaseOrderItemDetail = new HashSet<IMS_PurchaseOrderItemDetail>();
        }

        public int Id { get; set; }

        public int orderNo { get; set; }

        public string orderCode { get; set; }

        public DateTime orderDate { get; set; }

        public string orderType { get; set; }

        public string excutiveApproveStatus { get; set; }

        public DateTime? excutiveApproveDate { get; set; }

        public string excutiveApproveBy { get; set; }

        public int accountId { get; set; }

        public DateTime? entryDate { get; set; }

        public string entryBy { get; set; }

        public int sequenceNo { get; set; }

        public int requistionId { get; set; }

        public virtual IMS_Accounts IMS_Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_PurchaseOrderItemDetail> IMS_PurchaseOrderItemDetail { get; set; }
    }
}
