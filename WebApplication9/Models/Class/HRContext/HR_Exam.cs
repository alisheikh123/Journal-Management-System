namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Exam
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ExamName { get; set; }

        public int EducationId { get; set; }

        public virtual HR_Education HR_Education { get; set; }
    }
}
