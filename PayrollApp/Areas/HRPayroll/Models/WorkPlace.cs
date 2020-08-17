using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class WorkPlace
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
    }
}
