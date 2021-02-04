namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblStu_Fee_Record
    {
        public int id { get; set; }

        public int? Stu_RegNo { get; set; }

        public int? Stu_RollNo { get; set; }

        public int? semester { get; set; }

        public string DeptID { get; set; }

        public string Program_id { get; set; }

        [StringLength(50)]
        public string Payment_type { get; set; }

        public int? Instalments { get; set; }

        public int? Remaining_Installments { get; set; }

        public double? Tuition_fee { get; set; }

        public double? org_tution_Fee { get; set; }

        public double? Constant_Fee { get; set; }

        public double? Payed_Fee_Semester { get; set; }

        public double? Payed_Fee_tuition { get; set; }

        public double? Remaining_Fee { get; set; }

        public string Date { get; set; }

        public bool? status { get; set; }

        public string Discount { get; set; }

        public double? Total_Fee { get; set; }

        public bool? Inst_No { get; set; }

        public string bank_date { get; set; }

        public string Sec_date { get; set; }

        public string OverDues { get; set; }
    }
}
