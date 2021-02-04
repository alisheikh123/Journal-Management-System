namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_LeaveDayLimitEmpType
    {
        public int Id { get; set; }

        public int leaveType_Id { get; set; }

        public int employeeTypeId { get; set; }

        public int daysLimit { get; set; }

        public virtual HR_EmployeeType HR_EmployeeType { get; set; }

        public virtual HR_LeaveTypes HR_LeaveTypes { get; set; }
    }
}
