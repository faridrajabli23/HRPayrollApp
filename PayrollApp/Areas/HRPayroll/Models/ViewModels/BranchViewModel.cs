using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class BranchViewModel
    {
        public BranchAddModel BranchAddModel { get; set; }
        public List<Branch> Branches { get; set; }
        public List<Company> Companies { get; set; }
    }
}
