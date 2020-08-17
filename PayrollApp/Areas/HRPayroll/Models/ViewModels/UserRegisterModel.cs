using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage =("Please provide username"))]
        [MaxLength(30, ErrorMessage = "Surname is too long")]
        public string UserName { get; set; }

        [Required(ErrorMessage =("Please provide email"))]
        [DataType(DataType.EmailAddress, ErrorMessage =("Email is not valid"))]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please provide password")]
        [DataType(DataType.Password, ErrorMessage =("Password is not valid"))]
        [MinLength(8,ErrorMessage = "The lenght of password must be at least 8 char")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",ErrorMessage ="Invalid password, minimum one lowercase letter, minimum one uppercase letter, minimum one number and minimum one character(! @ # $%^&*()_+*-/?|;~)")]
        public string Password { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide a name")]
        [MaxLength(15, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Surname can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide a surname")]
        [MaxLength(20, ErrorMessage = "Surname is too long")]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage =("Phone number is not valid"))]
        public string PhoneNumber { get; set; }
        public List<Department> Departments { get; set; }
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please upload a photo")]
        public IFormFile Photo { get; set; }
    }
}
