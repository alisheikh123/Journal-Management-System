namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_DesignationSalary
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Designation { get; set; }

        public decimal? BasicSalary { get; set; }

        public decimal? SalaryPerDay { get; set; }

        [StringLength(20)]
        public string HRA { get; set; }

        [StringLength(20)]
        public string TA { get; set; }

        [StringLength(20)]
        public string OCA { get; set; }

        public int? Month { get; set; }

        public int? Year { get; set; }

        public string ProffesionalFund { get; set; }

        public int NoOfLeaves { get; set; }

        public decimal? Earnings { get; set; }

        public decimal? Deductions { get; set; }

        public decimal? NetSalary { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
