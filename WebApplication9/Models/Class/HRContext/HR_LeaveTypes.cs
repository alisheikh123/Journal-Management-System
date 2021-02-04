namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_LeaveTypes()
        {
            HR_LeaveDayLimitEmpType = new HashSet<HR_LeaveDayLimitEmpType>();
            HR_LeaveRequest = new HashSet<HR_LeaveRequest>();
        }

        public int Id { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public string leaveType_Name { get; set; }

        public int daysLimit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_LeaveDayLimitEmpType> HR_LeaveDayLimitEmpType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_LeaveRequest> HR_LeaveRequest { get; set; }
    }
}
