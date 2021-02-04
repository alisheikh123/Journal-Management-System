namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tabRank
    {
        public int id { get; set; }

        public string rankId { get; set; }

        public string rankName { get; set; }
    }
}
