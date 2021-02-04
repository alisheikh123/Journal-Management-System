namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Deduction
    {
        [Key]
        public int deduction_Id { get; set; }

        public string deduction_Reason { get; set; }

        public DateTime deduction_Date { get; set; }

        public int EmployeeId { get; set; }

        public int? payMasterId { get; set; }

        public int? entryBy { get; set; }

        public DateTime? entryDate { get; set; }

        public int? updateEntryBy { get; set; }

        public DateTime? updateEntryDate { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
