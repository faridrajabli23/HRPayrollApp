using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels.PayrollSpecialist
{
    public class CalcViewModel
    {
        public string EmployeeId { get; set; }
        public string EmployeePayId { get; set; }
        public List<CalculatedEmployeePay> CalculatedEmployeePays { get; set; }
    }
}
