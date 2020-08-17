using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class DepartmentNameEdit
    {
        [Required(ErrorMessage = "Please provide name")]
        [MaxLength(30, ErrorMessage = "Name is too long")]
        public string Name { get; set; }
        public int HoldingId { get; set; }
        public int Id { get; set; }
    }
}
