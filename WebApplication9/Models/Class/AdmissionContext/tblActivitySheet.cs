namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblActivitySheet")]
    public partial class tblActivitySheet
    {
        public int id { get; set; }

        public DateTime activityDate { get; set; }

        [Required]
        public string activityHead { get; set; }

        public string activitySubHead { get; set; }

        [Required]
        public string activityDetail { get; set; }
    }
}
