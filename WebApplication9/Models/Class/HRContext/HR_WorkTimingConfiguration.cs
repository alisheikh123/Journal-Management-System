namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_WorkTimingConfiguration
    {
        public int Id { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public double DutyHrs { get; set; }

        public DateTime UpdateAt { get; set; }

        public string UpdateBy { get; set; }
    }
}
