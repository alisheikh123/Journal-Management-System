namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplyProgram
    {
        public int id { get; set; }

        public string applicationNo { get; set; }

        public string priority { get; set; }

        public string applicationDate { get; set; }

        public string departmentID { get; set; }

        public string studentRegNo { get; set; }

        public string date { get; set; }

        public string admkitstatus { get; set; }

        public string Unselected { get; set; }

        public string SemiSelected { get; set; }

        public string feestatus { get; set; }

        public string Selected { get; set; }

        public string DateSelected { get; set; }

        public string Final { get; set; }

        public string DateFinal { get; set; }

        public string Semester { get; set; }
    }
}
