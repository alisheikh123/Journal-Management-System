namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_WorkingDaysForDepartmentConfiguration
    {
        public int Id { get; set; }

        public int WeekDayNo { get; set; }

        public int DepartmentId { get; set; }

        public string UpdateBy { get; set; }
    }
}
