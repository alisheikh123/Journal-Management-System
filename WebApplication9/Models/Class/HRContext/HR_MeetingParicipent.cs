namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_MeetingParicipent
    {
        public int Id { get; set; }

        public int MeetingId { get; set; }

        public string UserId { get; set; }

        public bool IsPresent { get; set; }

        public bool IsSpecialGuest { get; set; }

        public virtual HR_Meeting HR_Meeting { get; set; }
    }
}
