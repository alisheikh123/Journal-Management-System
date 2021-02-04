namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUogFeeChallan")]
    public partial class tblUogFeeChallan
    {
        public int id { get; set; }

        public string RegNo { get; set; }

        public string RollNo { get; set; }

        public string Name { get; set; }

        public string FatherName { get; set; }

        public string Program { get; set; }

        public string Dept { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BalanceCF { get; set; }

        public string ReAdmissionFee { get; set; }

        public string TuitionFee { get; set; }

        public string DiscountRate { get; set; }

        public string DiscountAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiscountedTuitionFee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ExaminationFee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ITServiceFee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MiscChallanFee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProcessingFee { get; set; }

        public string RepeatCourseFee { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalFeeReceivable { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FirstDeposit { get; set; }

        public string FirstDepositDate { get; set; }

        public string SecondDeposit { get; set; }

        public string SecondDepositDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalFeeReceipts { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OutstandingFee { get; set; }

        public string Remarks { get; set; }

        public int? programId { get; set; }

        public int? deptId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dueDate { get; set; }
    }
}
