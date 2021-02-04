namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMoodleUser
    {
        public int id { get; set; }

        [StringLength(50)]
        public string RegID { get; set; }

        [StringLength(50)]
        public string firstName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string fatherName { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string rollNo { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
}
