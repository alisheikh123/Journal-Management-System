namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_PurchaseOrderItem
    {
        public int id { get; set; }

        public int item_id { get; set; }

        public int PR_PurchaseOrder_id { get; set; }

        public string others_name { get; set; }

        public int item_quatitiy { get; set; }

        public string status { get; set; }

        public int vendor_id { get; set; }

        [StringLength(50)]
        public string order_remarks { get; set; }

        public float price_pu { get; set; }

        public virtual PR_Inventory_Item PR_Inventory_Item { get; set; }

        public virtual PR_PurchaseOrder PR_PurchaseOrder { get; set; }

        public virtual PR_VendorList PR_VendorList { get; set; }
    }
}
