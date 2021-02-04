namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeSkill
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int SkillId { get; set; }

        [Required]
        [StringLength(150)]
        public string Details { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }

        public virtual HR_Skill HR_Skill { get; set; }
    }
}
