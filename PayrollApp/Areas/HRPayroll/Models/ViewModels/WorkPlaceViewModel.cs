using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class WorkPlaceViewModel
    {
        public Employee Employee { get; set; }
        public WorkPlace WorkPlace { get; set; }
    }
}
