using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class StipulationAddModel
    {
        [Required(ErrorMessage ="please provide limit")]
        public double Limit { get; set; }
        public string PercentOrAmount { get; set; }
        public double Percent { get; set; }
        public double Amount { get; set; }
        public List<Company> Companies { get; set; }
        public int CompanyId { get; set; }
    }
}
