namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_EmployeeType()
        {
            HR_LeaveDayLimitEmpType = new HashSet<HR_LeaveDayLimitEmpType>();
        }

        [Key]
        public int employeeTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string empTypeName { get; set; }

        [Required]
        [StringLength(5)]
        public string empTypeCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_LeaveDayLimitEmpType> HR_LeaveDayLimitEmpType { get; set; }
    }
}
