namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LR_Category()
        {
            LR_BookCategory = new HashSet<LR_BookCategory>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(35)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string shortname { get; set; }

        public DateTime? date { get; set; }

        public int parent { get; set; }

        public string Activity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_BookCategory> LR_BookCategory { get; set; }
    }
}
