namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_RecruitmentRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_RecruitmentRequest()
        {
            HR_Vacancie = new HashSet<HR_Vacancie>();
        }

        public int Id { get; set; }

        public int EmploymentId { get; set; }

        public int DesignationId { get; set; }

        public int DepartmentId { get; set; }

        [Required]
        public string RequestedBy { get; set; }

        public int PositionStatus { get; set; }

        public int AdvertisingType { get; set; }

        public DateTime PreferredStartDate { get; set; }

        public DateTime ApplyTill { get; set; }

        public bool IsWorkloadExceeded { get; set; }

        public bool IsHaveSoakPermission { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool OpenVacancy { get; set; }

        public string Reason { get; set; }

        public bool isCancled { get; set; }

        [Required]
        public string EligibiltyCriteria { get; set; }

        public int NoOfVacancies { get; set; }

        public double Experience { get; set; }

        public virtual HR_Designation HR_Designation { get; set; }

        public virtual HR_Employment HR_Employment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_Vacancie> HR_Vacancie { get; set; }
    }
}
