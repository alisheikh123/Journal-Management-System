namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_PayrollMaster
    {
        [Key]
        public int payrollmaster_Id { get; set; }

        public DateTime payroll_Month { get; set; }

        public string Description { get; set; }

        public string payroll_GenerateBy { get; set; }

        public DateTime? generateDateTime { get; set; }

        public string updateBy { get; set; }

        public DateTime? updateDateTime { get; set; }
    }
}
