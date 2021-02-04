namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeTrainingHistory
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingTitle { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingTopic { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingInstitute { get; set; }

        [Required]
        [StringLength(25)]
        public string IstituteLocation { get; set; }

        [Required]
        [StringLength(25)]
        public string InstituteCountry { get; set; }

        public int TrainingYear { get; set; }

        [Required]
        [StringLength(25)]
        public string TrainingDuration { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
