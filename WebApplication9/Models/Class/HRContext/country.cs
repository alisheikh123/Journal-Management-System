namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class country
    {
        public int id { get; set; }

        public string sortname { get; set; }

        public string name { get; set; }

        public string phonecode { get; set; }
    }
}
