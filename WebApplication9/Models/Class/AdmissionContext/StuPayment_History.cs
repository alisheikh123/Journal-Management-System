namespace WebApplication9.Models.Class.AdmissionContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StuPayment_History
    {
        public int Id { get; set; }

        public int StuRegNo { get; set; }

        public string DueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PayDate { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        public int? Installments { get; set; }

        public int? RemainingInstallments { get; set; }

        public byte? SemesterNo { get; set; }

        public double? ConstantFee { get; set; }

        public double? FeePaid_Semester { get; set; }

        public double? FeePaid_Tution { get; set; }

        public double? Remaining_Fee { get; set; }

        public string install_no { get; set; }

        public string duesgiven { get; set; }

        public string discount { get; set; }

        public double? totalfee { get; set; }

        public string Date_insert { get; set; }

        public string Outstanding_dues { get; set; }

        public string Previoues_blance { get; set; }

        public string accid { get; set; }
    }
}
