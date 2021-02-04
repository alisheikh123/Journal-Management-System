namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Leave
    {
        public int Id { get; set; }

        public DateTime? Date_Start { get; set; }

        public DateTime? Date_Finish { get; set; }

        public string Reason { get; set; }

        public int Status { get; set; }
    }
}
