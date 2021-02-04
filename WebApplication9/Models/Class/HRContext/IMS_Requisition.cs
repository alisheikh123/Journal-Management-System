namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMS_Requisition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMS_Requisition()
        {
            IMS_RequisitionDetail = new HashSet<IMS_RequisitionDetail>();
        }

        public int Id { get; set; }

        public int requisitionTypeId { get; set; }

        public int departmentId { get; set; }

        public string headApproveStatus { get; set; }

        public DateTime? headApproveDate { get; set; }

        public string headApproveBy { get; set; }

        public int priority { get; set; }

        public DateTime requireByDate { get; set; }

        public string status { get; set; }

        public string remarks { get; set; }

        public string excutiveApproveStatus { get; set; }

        public DateTime? excutiveApproveDate { get; set; }

        public string excutiveApproveBy { get; set; }

        public int requisitionNo { get; set; }

        public string requisitionCode { get; set; }

        public DateTime requisitionDate { get; set; }

        public string requisitionType { get; set; }

        public string requisitionGeneratedBy { get; set; }

        public string ProcurementApproveStatus { get; set; }

        public DateTime? ProcurementApproveDate { get; set; }

        public string ProcurementApprovedBy { get; set; }

        public virtual IMS_RequisitionType IMS_RequisitionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMS_RequisitionDetail> IMS_RequisitionDetail { get; set; }
    }
}
