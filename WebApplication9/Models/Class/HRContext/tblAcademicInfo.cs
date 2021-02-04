namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAcademicInfo")]
    public partial class tblAcademicInfo
    {
        public int Id { get; set; }

        public string RegistrationId { get; set; }

        public int ExamLevel { get; set; }

        public int ExamType { get; set; }

        public string CourseFromYear { get; set; }

        public string CourseToYear { get; set; }

        public string Board { get; set; }

        public string Cname { get; set; }

        public string CandidateRollNumber { get; set; }

        public string UploadResultCard { get; set; }

        public string SchoolCollegeUniversity { get; set; }

        public string City { get; set; }

        public double? TotalMarks { get; set; }

        public double? ObtainedMarks { get; set; }

        [StringLength(50)]
        public string Percentage { get; set; }

        public string degreeType { get; set; }

        public string major { get; set; }

        public virtual tblExamType tblExamType { get; set; }
    }
}
