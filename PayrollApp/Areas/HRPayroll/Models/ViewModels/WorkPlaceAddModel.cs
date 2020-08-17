using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class WorkPlaceAddModel
    {
        public int Id { get; set; }
        public List<Department> Departments { get; set; }
        [Required(ErrorMessage ="Please provie start date")]
        public string StartDate { get; set; }
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
