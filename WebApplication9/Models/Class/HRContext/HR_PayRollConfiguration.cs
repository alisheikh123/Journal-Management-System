namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_PayRollConfiguration
    {
        public int Id { get; set; }

        public int BS_Perc { get; set; }

        public int HA_Perc { get; set; }

        public int TA_Perc { get; set; }

        public int OCA__Perc { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
