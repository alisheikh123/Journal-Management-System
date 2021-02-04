namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeEducation
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int EducationId { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string InstituteName { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [Required]
        [StringLength(25)]
        public string Duration { get; set; }

        public int PassingYear { get; set; }

        public string filePath { get; set; }

        public bool? IsApprovedByAdmin { get; set; }

        public virtual HR_Education HR_Education { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
