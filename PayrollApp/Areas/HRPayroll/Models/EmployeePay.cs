using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class EmployeePay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string PassportId { get; set; }
        public string WorkDate { get; set; }
        public string Gender { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Position Position { get; set; }
        public int PositionId { get; set; }

        [NotMapped]
        public bool IsChecked { get; set; }
    }
}
