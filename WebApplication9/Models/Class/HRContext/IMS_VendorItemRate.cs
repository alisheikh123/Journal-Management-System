namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_VendorItemRate
    {
        public int Id { get; set; }

        public int accountId { get; set; }

        public int itemId { get; set; }

        public decimal Rate { get; set; }

        public string Description { get; set; }

        public virtual IMS_Accounts IMS_Accounts { get; set; }

        public virtual IMS_Item IMS_Item { get; set; }
    }
}
