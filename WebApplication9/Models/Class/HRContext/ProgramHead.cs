namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProgramHead
    {
        public int Id { get; set; }

        public int ProgramId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Visible { get; set; }
    }
}
