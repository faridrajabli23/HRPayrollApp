using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Areas.HRPayroll.Models.ViewModels
{
    public class OldWorkDetailModel
    {
        public List<OldWorkPlace> OldWorkPlaces { get; set; }
        public Employee Employee { get; set; }
    }
}
