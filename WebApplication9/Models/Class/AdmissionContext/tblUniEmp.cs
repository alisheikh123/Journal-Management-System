namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUniEmp")]
    public partial class tblUniEmp
    {
        public int id { get; set; }

        public string Name { get; set; }

        public string EmpID { get; set; }

        public string Gender { get; set; }

        public string Num { get; set; }

        public string DeptID { get; set; }

        public string SubDeptID { get; set; }

        public string Designation { get; set; }

        public string Rank { get; set; }

        public string ProgramID { get; set; }

        public string Email { get; set; }

        public string Pic { get; set; }

        public string Cnic { get; set; }

        public string City { get; set; }
    }
}
