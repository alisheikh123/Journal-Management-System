namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Designation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Designation()
        {
            HR_Employee = new HashSet<HR_Employee>();
            HR_EmploymentHistory = new HashSet<HR_EmploymentHistory>();
            HR_RecruitmentRequest = new HashSet<HR_RecruitmentRequest>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string DesignationCode { get; set; }

        [Required]
        [StringLength(50)]
        public string DesignationName { get; set; }

        public int PayGradeId { get; set; }

        public int Ranking { get; set; }

        public virtual HR_PayGrade HR_PayGrade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_Employee> HR_Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmploymentHistory> HR_EmploymentHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_RecruitmentRequest> HR_RecruitmentRequest { get; set; }
    }
}
