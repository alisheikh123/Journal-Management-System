namespace WebApplication9.Models.Class.HRContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HR_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Employee()
        {
            HR_Deduction = new HashSet<HR_Deduction>();
            HR_DesignationSalary = new HashSet<HR_DesignationSalary>();
            HR_EmployeEducation = new HashSet<HR_EmployeEducation>();
            HR_EmployeeLanguage = new HashSet<HR_EmployeeLanguage>();
            HR_EmployeeSkill = new HashSet<HR_EmployeeSkill>();
            HR_EmployeeTrainingHistory = new HashSet<HR_EmployeeTrainingHistory>();
            HR_EmploymentHistory = new HashSet<HR_EmploymentHistory>();
            HR_EmplyeeResearch = new HashSet<HR_EmplyeeResearch>();
            HR_LeaveRecord = new HashSet<HR_LeaveRecord>();
            HR_LeaveRequest = new HashSet<HR_LeaveRequest>();
            HR_PayrollDetail = new HashSet<HR_PayrollDetail>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(17)]
        public string EmployeeRegNo { get; set; }

        [Required]
        [StringLength(10)]
        public string NationalID { get; set; }

        public DateTime BirthDate { get; set; }

        public int MaritalStatus { get; set; }

        public int Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string Nationality { get; set; }

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

        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public string BadgeNumber { get; set; }

        [StringLength(255)]
        public string EmailUSKT { get; set; }

        public virtual HR_Country HR_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_Deduction> HR_Deduction { get; set; }

        public virtual HR_Designation HR_Designation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_DesignationSalary> HR_DesignationSalary { get; set; }

        public virtual HR_District HR_District { get; set; }

        public virtual HR_Division HR_Division { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmployeEducation> HR_EmployeEducation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmployeeLanguage> HR_EmployeeLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmployeeSkill> HR_EmployeeSkill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmployeeTrainingHistory> HR_EmployeeTrainingHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmploymentHistory> HR_EmploymentHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_EmplyeeResearch> HR_EmplyeeResearch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_LeaveRecord> HR_LeaveRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_LeaveRequest> HR_LeaveRequest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_PayrollDetail> HR_PayrollDetail { get; set; }
    }
}
