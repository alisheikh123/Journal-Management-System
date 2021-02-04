namespace WebApplication9.Models.Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Allowance
    {
        [Key]
        public int allowanceId { get; set; }

        public int allowanceType_Id { get; set; }

        public int EmployeeId { get; set; }

        public decimal allowancePercentage { get; set; }

        public decimal allowanceAmount { get; set; }

        public virtual HR_Employee HR_Employee { get; set; }
    }
}
