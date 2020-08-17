using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class CompanyDepartmentViewModel
    {
        public List<Company> Companies { get; set; }
        public List<Department> Departments { get; set; }
        public CompanyAddModel CompanyAddModel { get; set; }
    }
}
