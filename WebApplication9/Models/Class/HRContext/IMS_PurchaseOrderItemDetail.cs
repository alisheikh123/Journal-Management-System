namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_PurchaseOrderItemDetail
    {
        public int Id { get; set; }

        public int orderId { get; set; }

        public int itemId { get; set; }

        public decimal quantity { get; set; }

        public decimal price { get; set; }

        public decimal amount { get; set; }

        public string Description { get; set; }

        public string status { get; set; }

        public string remarks { get; set; }

        public virtual IMS_Item IMS_Item { get; set; }

        public virtual IMS_PurchaseOrder IMS_PurchaseOrder { get; set; }
    }
}
