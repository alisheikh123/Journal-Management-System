namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmployeeLanguage
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int LanguageId { get; set; }

        public int Reading { get; set; }

        public int Speaking { get; set; }

        public int Writing { get; set; }

        public int Understanding { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }

        public virtual HR_Language HR_Language { get; set; }
    }
}
