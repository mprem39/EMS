using EMS.CustomValidators;
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

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter Name")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Emp Name should contain alphabets only.")]
        public string EmployeeName { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Enter Designation")]
        public string EmployeeDesignation { get; set; }

        [Range(1000, 50000, ErrorMessage = "Salary should be in between 1000 and 50000.")] 
        [Required(ErrorMessage = "Salary can't be blank")] 
        public decimal Salary { get; set; }
     
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Enter Address")]
        public string EmployeeAddress { get; set; }

        [Required(ErrorMessage = "Email can't be blank.")]
        [RegularExpression(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})", ErrorMessage = "Invalid E-Mail.")]
        public string Email { get; set; }
       
        [Display(Name = "Passport")]
        public string EmployeePassport { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Enter Phone")]
        [PhoneLengthAttribute(10)]
        public long EmployeePhone { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        [Display(Name = "Gender")]
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

        public Department Department { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
    }
}