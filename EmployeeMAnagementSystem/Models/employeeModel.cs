using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMAnagementSystem.Models
{
    public class employeeModel
    {
        [Key]
        public int employeeId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Place is required.")]
        [StringLength(100, ErrorMessage = "Place cannot be longer than 100 characters.")]
        [Display(Name = "Place")]
        public string place { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        [Display(Name = "Description")]
        public string description { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [Display(Name = "Email")]
        public string email { get; set; }
    }
}