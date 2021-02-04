namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmploymentHistory
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyLocation { get; set; }

        public int DepartmentId { get; set; }

        public int DesignationId { get; set; }

        public DateTime EmploymentFromDate { get; set; }

        public int IsCurrentEmployee { get; set; }

        public DateTime EmploymentToDate { get; set; }

        [Required]
        [StringLength(150)]
        public string Responsibilities { get; set; }

        public virtual HR_Designation HR_Designation { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
