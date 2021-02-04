namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_PayrollSetup
    {
        [Key]
        public int payrollSetup_Id { get; set; }

        public int EmployeeId { get; set; }

        public decimal basicSalary { get; set; }

        public decimal houseAllowance { get; set; }

        public decimal ConveyanceAllowance { get; set; }

        public decimal utilitiesAllowance { get; set; }

        public decimal phoneAllowance { get; set; }

        public decimal otherAllowance { get; set; }

        public decimal tax { get; set; }

        public decimal otherDeduction { get; set; }

        public decimal taxPercent { get; set; }

        public decimal grossSalary { get; set; }

        public decimal netSalary { get; set; }
    }
}
