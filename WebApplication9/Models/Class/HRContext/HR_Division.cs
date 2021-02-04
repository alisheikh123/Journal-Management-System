namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Division
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Division()
        {
            HR_Employee = new HashSet<HR_Employee>();
        }

        public int Id { get; set; }

        public int CountryId { get; set; }

        [Required]
        [StringLength(5)]
        public string DivisionCode { get; set; }

        [Required]
        [StringLength(50)]
        public string DivisionName { get; set; }

        public virtual HR_Country HR_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_Employee> HR_Employee { get; set; }
    }
}
