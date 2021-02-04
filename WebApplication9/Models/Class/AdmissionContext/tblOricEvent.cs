namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblOricEvent
    {
        public int id { get; set; }

        public DateTime eventDate { get; set; }

        [Required]
        public string eventDetail { get; set; }
    }
}
