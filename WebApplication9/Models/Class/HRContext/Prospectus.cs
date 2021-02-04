namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prospectus
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Path { get; set; }
    }
}
