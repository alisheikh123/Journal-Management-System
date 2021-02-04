namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LR_UserCategoryLogs
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        public int priority { get; set; }

        public string status { get; set; }

        public int userid { get; set; }

        public string name { get; set; }
    }
}
