using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models
{
    public class AbsentReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExcusableOrInexcusable { get; set; }
    }
}
