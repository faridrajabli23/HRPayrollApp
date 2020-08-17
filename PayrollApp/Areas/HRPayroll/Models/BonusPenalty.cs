using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class BonusPenalty
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Reason { get; set; }
        public string Date { get; set; }
        public string BonusOrPenalty { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}
