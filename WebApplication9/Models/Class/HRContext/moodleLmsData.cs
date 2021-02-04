namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("moodleLmsData")]
    public partial class moodleLmsData
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string userid { get; set; }
    }
}
