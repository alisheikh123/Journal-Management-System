namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Employment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Employment()
        {
            HR_RecruitmentRequest = new HashSet<HR_RecruitmentRequest>();
        }

        [Key]
        public int employment_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string employment_Name { get; set; }

        [Required]
        [StringLength(5)]
        public string employment_Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_RecruitmentRequest> HR_RecruitmentRequest { get; set; }
    }
}
