namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeCertification
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int CertificationId { get; set; }

        [Required]
        public string InstituteName { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [StringLength(250)]
        public string filePath { get; set; }

        public bool? IsApprovedByAdmin { get; set; }

        public virtual HR_Certification HR_Certification { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
