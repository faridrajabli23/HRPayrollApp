using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
