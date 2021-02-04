namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblFaculty_USKT
    {
        [Key]
        public int fac_Id { get; set; }

        public string img { get; set; }

        public bool? hod { get; set; }

        [StringLength(50)]
        public string fname { get; set; }

        [StringLength(50)]
        public string lname { get; set; }

        [StringLength(80)]
        public string rank { get; set; }

        public string Past_Experience { get; set; }

        [StringLength(50)]
        public string depertment_Name { get; set; }

        [StringLength(50)]
        public string dept_Id { get; set; }

        [StringLength(50)]
        public string faculty_Name { get; set; }

        public int? faculty_Id { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string fb { get; set; }

        [StringLength(50)]
        public string twitter { get; set; }

        [StringLength(50)]
        public string google { get; set; }

        [StringLength(50)]
        public string linkdin { get; set; }

        public byte? hod1 { get; set; }
    }
}
