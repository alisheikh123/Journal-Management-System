namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_UserCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LR_UserCategory()
        {
            LR_AssignRolestoUsers = new HashSet<LR_AssignRolestoUsers>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(35)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string shortname { get; set; }

        public int priority { get; set; }

        public DateTime? date { get; set; }

        public int BIssue_Limit { get; set; }

        public int FirstIDays { get; set; }

        public int ReIDays { get; set; }

        public int attempts { get; set; }

        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_AssignRolestoUsers> LR_AssignRolestoUsers { get; set; }
    }
}
