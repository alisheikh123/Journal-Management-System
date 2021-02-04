namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMS_Item()
        {
            IMS_PurchaseOrderItemDetail = new HashSet<IMS_PurchaseOrderItemDetail>();
            IMS_RequisitionDetail = new HashSet<IMS_RequisitionDetail>();
            IMS_VendorItemRate = new HashSet<IMS_VendorItemRate>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Unit { get; set; }

        public int ItemNumber { get; set; }

        public string ItemCode { get; set; }

        public int IMS_ItemUnitId { get; set; }

        public int IMS_ItemTypeId { get; set; }

        public int IMS_SubCategoryId { get; set; }

        public virtual IMS_ItemType IMS_ItemType { get; set; }

        public virtual IMS_ItemUnit IMS_ItemUnit { get; set; }

        public virtual IMS_SubCategory IMS_SubCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_PurchaseOrderItemDetail> IMS_PurchaseOrderItemDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_RequisitionDetail> IMS_RequisitionDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_VendorItemRate> IMS_VendorItemRate { get; set; }
    }
}
