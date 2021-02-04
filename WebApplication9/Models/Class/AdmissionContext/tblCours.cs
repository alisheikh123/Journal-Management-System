namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCourses")]
    public partial class tblCours
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string proName { get; set; }

        public int? courseID { get; set; }

        [StringLength(50)]
        public string courseShortName { get; set; }
    }
}
