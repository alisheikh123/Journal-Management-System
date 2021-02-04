namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_ApiConfig
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BaseUrl { get; set; }

        public string Token { get; set; }

        public string Description { get; set; }
    }
}
