namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveRequest
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int LeaveTypesId { get; set; }

        public DateTime LeaveFrom { get; set; }

        public DateTime LeaveTo { get; set; }

        public int? Days { get; set; }

        public string Reason { get; set; }

        public DateTime? RequestDate { get; set; }

        public int? Status { get; set; }

        public int PartialApproveDays { get; set; }

        public int Hod_Status { get; set; }

        public int Director_Status { get; set; }

        public string Director_Comments { get; set; }

        public int PaidType { get; set; }

        public string HR_Comments { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }

        public virtual HR_LeaveTypes HR_LeaveTypes { get; set; }
    }
}
