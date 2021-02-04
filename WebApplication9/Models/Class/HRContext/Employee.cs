namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public string EmployeeRegNo { get; set; }

        public string BadgeNumber { get; set; }

        [Required]
        [StringLength(17)]
        public string NationalID { get; set; }

        public DateTime BirthDate { get; set; }

        public int MaritalStatus { get; set; }

        public int Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string Nationality { get; set; }

        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public string HouseNo { get; set; }

        public string RoadNo { get; set; }

        public string Village { get; set; }

        public int? CountryId { get; set; }

        public int? DivisionId { get; set; }

        public int? DistrictId { get; set; }

        public string PostalCode { get; set; }

        public DateTime? JoiningDate { get; set; }

        public DateTime? DateOfPermanency { get; set; }

        public string JobTitle { get; set; }

        public int EmployeeType { get; set; }

        public int EmployementStatus { get; set; }

        public int? DepartmentId { get; set; }

        public int? DesignationId { get; set; }

        public decimal? TotalSalaryPackage { get; set; }

        public int? Status { get; set; }

        public string Comment { get; set; }

        [StringLength(100)]
        public string NTN { get; set; }

        [StringLength(100)]
        public string bankName { get; set; }

        [StringLength(100)]
        public string bankBranchCode { get; set; }

        [StringLength(100)]
        public string accountNo { get; set; }

        [StringLength(100)]
        public string accountTittle { get; set; }

        [StringLength(100)]
        public string accountType { get; set; }

        [StringLength(100)]
        public string bankAddress { get; set; }

        public virtual Country1 Country { get; set; }

        public virtual Designation Designation { get; set; }

        public virtual District District { get; set; }

        public virtual Division Division { get; set; }
    }
}
