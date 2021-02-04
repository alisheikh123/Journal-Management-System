namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDetail
    {
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string uploadImage { get; set; }

        public string heading { get; set; }

        public string description { get; set; }
    }
}
