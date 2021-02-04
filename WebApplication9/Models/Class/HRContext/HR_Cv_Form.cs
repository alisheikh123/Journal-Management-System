namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Cv_Form
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(13)]
        public string PhoneNo { get; set; }

        [Required]
        public string Email { get; set; }

        public string CvPath { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public DateTime? interviewCallDate { get; set; }

        [Required]
        [StringLength(13)]
        public string CNIC { get; set; }
    }
}
