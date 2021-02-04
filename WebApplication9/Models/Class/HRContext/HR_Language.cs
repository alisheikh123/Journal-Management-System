namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Language
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Language()
        {
            HR_EmployeeLanguage = new HashSet<HR_EmployeeLanguage>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(3)]
        public string LanguageCode { get; set; }

        [Required]
        [StringLength(10)]
        public string LanguageName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmployeeLanguage> HR_EmployeeLanguage { get; set; }
    }
}
