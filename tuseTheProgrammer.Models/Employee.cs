using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tuseTheProgrammer.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is mandatory!")]
        [Display(Name="Fullname")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is mandatory!")]
        [EmailAddress(ErrorMessage = "Please enter a vaild email")]
        [Display(Name="Office Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Salary is mandatory!")]
        [Column(TypeName ="decimal(18,0)")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Department is mandatory!")]
        [Display(Name = "Occupation")]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        [Required(ErrorMessage = "Gender is mandatory!")]
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; } 
    }
}
