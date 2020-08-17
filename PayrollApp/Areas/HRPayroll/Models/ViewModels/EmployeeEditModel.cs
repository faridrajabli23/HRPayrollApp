using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class EmployeeEditModel
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide a name")]
        [MaxLength(12, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Surname can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide a surname")]
        [MaxLength(17, ErrorMessage = "Surname is too long")]
        public string Surname { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Father name can contain only a-z, A-z")]
        [Required(ErrorMessage = "Plase provide a father name")]
        [MaxLength(12, ErrorMessage = "Father name is too long")]
        public string Fathername { get; set; }

        [Required(ErrorMessage = "Please provide birthday")]
        public string Birthday { get; set; }

        [Required(ErrorMessage = "Please provide an address")]
        [MaxLength(22, ErrorMessage = "Address is too long")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please provide a register address")]
        [MaxLength(22, ErrorMessage = "Register address is too long")]
        public string RegisterAddress { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Passport id can contain only 0-9")]
        [Required(ErrorMessage = "Please provide passport id")]
        [MaxLength(8, ErrorMessage = "Passport id must be 8 character")]
        [MinLength(8, ErrorMessage = "Passport id must be 8 character")]
        public string PassportId { get; set; }

        [Required(ErrorMessage = "Please provide passport expiry date")]
        public string PassportExpDate { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Education can contain only a-z, A-z")]
        [Required(ErrorMessage = "Please provide education")]
        [MaxLength(25, ErrorMessage = "Education is too long")]
        public string Education { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }
        public IFormFile Photo { get; set; }
    }
}
