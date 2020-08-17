using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels.PayrollSpecialist
{
    public class CalculatedEmployeePay
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public double MonthSalary { get; set; }
        public int OneDayAbsent { get; set; }
        public int MoreDaysAbsent { get; set; }
        public int ExcusableAbsent { get; set; }
        public string WorkDate { get; set; }
        public string Gender { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeePayId { get; set; }
        public double TotalBonus { get; set; }
        public double TotalPenalty { get; set; }
        public double TotalSalary { get; set; }
        public int HolidayDays { get; set; }


    }
}
