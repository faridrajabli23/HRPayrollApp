using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class AdminEmployeeModel
    {
        public WorkPlace WorkPlace { get; set; }
        public List<OldWorkPlace> OldWorkPlaces { get; set; }

    }
}
