namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_IssueLogs
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        public int? student_id { get; set; }

        public string isbn { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string Status { get; set; }

        public int category { get; set; }

        public int remaining_quan { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
