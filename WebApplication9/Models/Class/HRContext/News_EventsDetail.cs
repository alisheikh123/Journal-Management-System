namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News_EventsDetail
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public string ShortDesc { get; set; }

        public string LongDesc { get; set; }

        public int? Type { get; set; }

        public string EventDate { get; set; }

        public bool IsHighlight { get; set; }

        public int? LocationNum { get; set; }

        public DateTime EventDateTime { get; set; }

        public string Link { get; set; }
    }
}
