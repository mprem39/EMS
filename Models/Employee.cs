using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Enter Employee Name")]
        public string EmployeeName { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Enter Designation")]
        public string EmployeeDesignation { get; set; }
        public Department Department { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Enter Address")]
        public string EmployeeAddress { get; set; }
        [Display(Name = "Passport")]
        public string EmployeePassport { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Enter Phone")]
        public long EmployeePhone { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        public string EmployeeGender { get; set; }

        [Required(ErrorMessage = "Enter City")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter Project")]
        [Display(Name = "Project")]
        public string Project { get; set; }
        [Required(ErrorMessage = "Enter Company Name")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Enter Pin Code")]
        [Display(Name = "Pin Code")]
        public int PinCode { get; set; }
        [Required(ErrorMessage = "Select Department")]
        [Display(Name = "Dept Name")]
        public int DepartmentId { get; set; }
    }
}