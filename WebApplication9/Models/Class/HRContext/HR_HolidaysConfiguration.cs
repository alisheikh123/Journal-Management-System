namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_HolidaysConfiguration
    {
        public int Id { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string Reason { get; set; }

        public DateTime UpdateAt { get; set; }

        public string UpdateBy { get; set; }

        public int Days { get; set; }
    }
}
