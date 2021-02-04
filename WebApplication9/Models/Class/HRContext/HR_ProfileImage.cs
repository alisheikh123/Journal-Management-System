namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_ProfileImage
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Path { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
