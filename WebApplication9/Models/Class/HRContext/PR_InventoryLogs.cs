namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_InventoryLogs
    {
        public int id { get; set; }

        public int item_id { get; set; }

        [Required]
        public string purchaseDate { get; set; }

        public int new_item_quantity { get; set; }

        public int old_item_quantity { get; set; }

        public float item_price_pu { get; set; }

        public float relvant_amount { get; set; }

        public DateTime log_date { get; set; }

        public string activity { get; set; }

        public int user_ID { get; set; }

        public int? location_id { get; set; }

        public int? vendor_id { get; set; }

        public string dep_Years { get; set; }

        public int dep_type { get; set; }

        public virtual PR_Inventory_Item PR_Inventory_Item { get; set; }

        public virtual PR_Location PR_Location { get; set; }

        public virtual PR_VendorList PR_VendorList { get; set; }
    }
}
