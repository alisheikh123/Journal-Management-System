namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventDetail")]
    public partial class EventDetail
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public string Heading { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }
    }
}
