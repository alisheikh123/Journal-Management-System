namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PR_RequisitionItem
    {
        public int id { get; set; }

        public int item_id { get; set; }

        public string others_name { get; set; }

        public int item_type_id { get; set; }

        public int item_category_id { get; set; }

        public int item_quatitiy { get; set; }

        public int status_id { get; set; }

        [StringLength(50)]
        public string order_remarks { get; set; }

        public long req_id { get; set; }

        public virtual PR_Category PR_Category { get; set; }

        public virtual PR_Inventory_Item PR_Inventory_Item { get; set; }

        public virtual PR_ReqStatus PR_ReqStatus { get; set; }

        public virtual PR_Requisition PR_Requisition { get; set; }

        public virtual PR_Type PR_Type { get; set; }
    }
}
