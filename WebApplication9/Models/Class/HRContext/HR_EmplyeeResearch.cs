namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_EmplyeeResearch
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string PublicationName { get; set; }

        public string PublicationDescription { get; set; }

        public string PublicationYear { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string ConferenceJournal { get; set; }

        public string Country { get; set; }

        public string Publisher { get; set; }

        public int AffiliationType { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
