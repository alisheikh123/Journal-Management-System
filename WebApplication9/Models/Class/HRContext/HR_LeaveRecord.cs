namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveRecord
    {
        [Key]
        public int leaveRecord_Id { get; set; }

        public DateTime leave_Date_Start { get; set; }

        public DateTime leave_Date_End { get; set; }

        public decimal? days { get; set; }

        [Required]
        public string leave_reason { get; set; }

        public int EmployeeId { get; set; }

        public int leaveTypeId { get; set; }

        public string entryBy { get; set; }

        public DateTime? entryDate { get; set; }

        public string updateEntryBy { get; set; }

        public DateTime? updateEntryDate { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
