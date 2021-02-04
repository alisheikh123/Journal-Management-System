namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Attendance
    {
        [Key]
        public int attendanceId { get; set; }

        public DateTime attendanceDate { get; set; }

        public string timeIn { get; set; }

        public string timeOut { get; set; }

        [StringLength(100)]
        public string attendanceStatus { get; set; }

        public int EmployeeId { get; set; }

        public int? leaveId { get; set; }

        [StringLength(100)]
        public string entry { get; set; }

        public string manulEntryBy { get; set; }

        public string entryBy { get; set; }

        public DateTime? entryDate { get; set; }

        public string updateEntryBy { get; set; }

        public DateTime? updateEntryDate { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
