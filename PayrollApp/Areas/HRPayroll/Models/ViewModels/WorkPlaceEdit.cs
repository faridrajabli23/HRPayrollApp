using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class WorkPlaceEdit
    {
        public int Id { get; set; }
        public List<Department> Departments { get; set; }
        [Required(ErrorMessage ="Please provide new position start date")]
        public string StartDate { get; set; }
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [Required(ErrorMessage ="Please provide old position end date")]
        public string OldWorkEndDate { get; set; }
    }
}
