using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels.PayrollSpecialist
{
    public class CalculatorModel
    {
        public Employee Employee { get; set; }
        public EmployeePay EmployeePay { get; set; }
        public List<EmployeePay> SameEmployeePays { get; set; }
        public decimal Salary { get; set; }
        public string Date { get; set; }
        public List<Absent> Absents { get; set; }
        public List<BonusPenalty> BonusPenalties { get; set; }
        public List<Stipulation> Stipulations { get; set; }
        public List<Holiday> Holidays { get; set; }
    }
}
