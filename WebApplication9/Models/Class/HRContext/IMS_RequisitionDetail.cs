namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_RequisitionDetail
    {
        public int Id { get; set; }

        public int requistionId { get; set; }

        public int itemId { get; set; }

        public decimal quantity { get; set; }

        public decimal quantityApprove { get; set; }

        public string status { get; set; }

        public string remarks { get; set; }

        public string Description { get; set; }

        public virtual IMS_Item IMS_Item { get; set; }

        public virtual IMS_Requisition IMS_Requisition { get; set; }
    }
}
