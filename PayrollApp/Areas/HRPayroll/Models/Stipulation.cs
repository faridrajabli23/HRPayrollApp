using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class Stipulation
    {
        public int Id { get; set; }
        public double Limit { get; set; }
        public string PercentOrAmount { get; set; }
        public double Percent { get; set; }
        public double Amount { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
