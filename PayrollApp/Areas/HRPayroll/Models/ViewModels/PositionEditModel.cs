using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class PositionEditModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide name")]
        [MaxLength(30, ErrorMessage = "Name is too long")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please provide position salary")]
        public double Salary { get; set; }
        public List<Company> Companies { get; set; }
        public int CompanyId { get; set; }
    }
}
