namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSubDept")]
    public partial class tblSubDept
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSubDept()
        {
            tblPrograms = new HashSet<tblProgram>();
        }

        public int id { get; set; }

        public string Deptt_Code { get; set; }

        public string Deptt_Name { get; set; }

        public string Fac_Code { get; set; }

        public int? Deptt_Id { get; set; }

        public int? empTypeId { get; set; }

        public int? parent_id { get; set; }

        public virtual tblDept1 tblDept { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProgram> tblPrograms { get; set; }
    }
}
