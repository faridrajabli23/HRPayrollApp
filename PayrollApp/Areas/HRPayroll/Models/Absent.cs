using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class Absent
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public AbsentReason AbsentReason { get; set; }
        public int AbsentReasonId { get; set; }
    }
}
