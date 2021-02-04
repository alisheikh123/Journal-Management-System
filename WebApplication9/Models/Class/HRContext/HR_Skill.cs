namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Skill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Skill()
        {
            HR_EmployeeSkill = new HashSet<HR_EmployeeSkill>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string SkillName { get; set; }

        public string Description { get; set; }

        public int SkillType { get; set; }

        public int? DepartmentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmployeeSkill> HR_EmployeeSkill { get; set; }
    }
}
