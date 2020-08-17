using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class DepartmentAdd
    {
        public List<Department> Departments { get; set; }
        [Required(ErrorMessage = "Please provide a name")]
        [MaxLength(20, ErrorMessage = "Name is too long")]
        public string Name { get; set; }
        public int HoldingId { get; set; }
    }
}
