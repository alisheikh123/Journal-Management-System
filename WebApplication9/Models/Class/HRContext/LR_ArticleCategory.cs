namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_ArticleCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LR_ArticleCategory()
        {
            LR_AlliedMaterial = new HashSet<LR_AlliedMaterial>();
            LR_Issue = new HashSet<LR_Issue>();
            LR_JournalsNews = new HashSet<LR_JournalsNews>();
            LR_ReIssue_Records = new HashSet<LR_ReIssue_Records>();
            LR_Reservations = new HashSet<LR_Reservations>();
            LR_ReturnBook = new HashSet<LR_ReturnBook>();
        }

        public int id { get; set; }

        public string catname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_AlliedMaterial> LR_AlliedMaterial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_Issue> LR_Issue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_JournalsNews> LR_JournalsNews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_ReIssue_Records> LR_ReIssue_Records { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_Reservations> LR_Reservations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LR_ReturnBook> LR_ReturnBook { get; set; }
    }
}
