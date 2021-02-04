namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_VendorItemCategory
    {
        public int Id { get; set; }

        public int accountId { get; set; }

        public int subCategoryId { get; set; }

        public virtual IMS_Accounts IMS_Accounts { get; set; }

        public virtual IMS_SubCategory IMS_SubCategory { get; set; }
    }
}
