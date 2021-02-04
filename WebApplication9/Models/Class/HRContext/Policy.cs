namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Policy
    {
        public int Id { get; set; }

        public string PolicyName { get; set; }

        public string Action { get; set; }

        public string Controller { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }
    }
}
